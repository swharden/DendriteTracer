﻿using System.Drawing;

namespace DendriteTracer.Core;

/// <summary>
/// This class is for breaking a projection series into a bunch of small ROIs and performing analyses on them.
/// ROI images are stored in 2D arrays (height = frame, width = roi).
/// </summary>
public class RoiCollection
{
    public string TifFilePath { get; }
    public int FrameCount { get; }
    public Roi[] Rois { get; }
    public double[] Positions { get; }
    public double[] Times { get; }
    public int RoiCount => Rois.Length;

    // TODO: replace 2d arrays with RoiData objects
    public RasterSharp.Channel[,] GreenImages { get; }
    public RasterSharp.Channel[,] RedImages { get; }
    public Bitmap[,] MergedImages { get; }
    public double[][] SortedRedPixelsByFrame { get; }
    public double[][] SortedGreenPixelsByFrame { get; }
    public double[,][] SortedRedPixelsByRoi { get; }
    public Bitmap[,] MaskImages { get; }
    public bool[,][,] Masks { get; }
    public double[,] RedMeans { get; }
    public double[,] GreenMeans { get; }
    public double[,] Ratios { get; }

    // TODO: replace with curve objects
    public double[][] RedCurveByFrame { get; }
    public double[][] GreenCurveByFrame { get; }
    public double[][] RatioCurveByFrame { get; }
    public double[] FrameTimes;

    public RoiExperimentSettings Settings { get; }

    public RoiCollection(RoiGenerator roiGen)
    {
        TifFilePath = roiGen.TifFilePath;
        FrameCount = roiGen.FrameCount;
        FrameTimes = roiGen.FrameTimes;
        Rois = roiGen.Tracing.GetEvenlySpacedRois();
        Positions = Enumerable.Range(0, RoiCount).Select(x => x * roiGen.Tracing.RoiSpacing_Microns).ToArray();
        Times = roiGen.FrameTimes;
        RedImages = Drawing.Crop(roiGen.RedImages, Rois);
        GreenImages = Drawing.Crop(roiGen.GreenImages, Rois);
        MergedImages = Drawing.GetMergedImages(RedImages, GreenImages, roiGen.Tracing.IsCircular, roiGen.Brightness);
        SortedRedPixelsByFrame = ArrayOperations.GetSortedPixels(roiGen.RedImages);
        SortedGreenPixelsByFrame = ArrayOperations.GetSortedPixels(roiGen.GreenImages);
        SortedRedPixelsByRoi = ArrayOperations.GetSortedPixels(RedImages);

        (MaskImages, Masks) = Drawing.GetMaskImages(RedImages, roiGen.Tracing.IsCircular);

        RedMeans = ArrayOperations.GetMeans(RedImages, Masks);
        GreenMeans = ArrayOperations.GetMeans(GreenImages, Masks);
        Ratios = ArrayOperations.GetRatios(RedMeans, GreenMeans);

        RedCurveByFrame = ArrayOperations.GetCurveByFrame(RedMeans);
        GreenCurveByFrame = ArrayOperations.GetCurveByFrame(GreenMeans);
        RatioCurveByFrame = ArrayOperations.GetCurveByFrame(Ratios);

        Settings = new()
        {
            TifFilePath = roiGen.TifFilePath,

            ImageFloor_Percent = roiGen.NoiseFloor_Percent,
            ImageFloor_IsEnabled = roiGen.NoiseFloor_IsEnabled,

            RoiSpacing_Microns = roiGen.Tracing.RoiSpacing_Microns,
            RoiRadius_Microns = roiGen.Tracing.RoiRadius_Microns,
            RoiIsCircular = roiGen.Tracing.IsCircular,
        };
    }

    /// <summary>
    /// Rows are frames (time), columns are ROIs (distance)
    /// </summary>
    public IO.CsvData GetDataByFrame(double[,] metric)
    {
        IO.CsvData csv = new();
        csv.AddCol(Times, "Time", "minutes");

        for (int roiIndex = 0; roiIndex < RoiCount; roiIndex++)
        {
            Core.IO.CsvColumn col = new()
            {
                Name = $"{Math.Round(Positions[roiIndex], 5)} µm",
                Units = "%",
                Comments = $"R/G",
            };

            for (int frameIndex = 0; frameIndex < FrameCount; frameIndex++)
            {
                col.AddCell(metric[frameIndex, roiIndex]);
            }

            csv.AddCol(col);
        }

        return csv;
    }

    /// <summary>
    /// Rows are ROIs (distance), columns are frame (time)
    /// </summary>
    public IO.CsvData GetDataByRoi(double[,] metric)
    {
        IO.CsvData csv = new();

        csv.AddCol(Positions, "Position", "µm");
        for (int frameIndex = 0; frameIndex < FrameCount; frameIndex++)
        {
            Core.IO.CsvColumn col = new()
            {
                Name = $"{Math.Round(Times[frameIndex], 5)} min",
                Units = "%",
                Comments = $"R/G",
            };

            for (int roiIndex = 0; roiIndex < RoiCount; roiIndex++)
            {
                col.AddCell(metric[frameIndex, roiIndex]);
            }

            csv.AddCol(col);
        }

        return csv;
    }
}