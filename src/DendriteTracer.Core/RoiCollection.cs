﻿using System.Drawing;

namespace DendriteTracer.Core;

/// <summary>
/// This class is for breaking a projection series into a bunch of small ROIs and performing analyses on them.
/// ROI images are stored in 2D arrays (height = frame, width = roi).
/// </summary>
public class RoiCollection
{
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
    public double[,][] SortedRedPixelsByRoi { get; }
    //public double[] NoiseFloorsByFrame { get; }
    public double[] ThresholdsByFrame { get; }
    public Bitmap[,] MaskImages { get; }
    public bool[,][,] Masks { get; }
    public double[,] RedMeans { get; }
    public double[,] GreenMeans { get; }
    public double[,] Ratios { get; }

    // TODO: replace with curve objects
    public double[][] RedCurveByFrame { get; }
    public double[][] GreenCurveByFrame { get; }
    public double[][] RatioCurveByFrame { get; }

    public RoiCollection(RoiGenerator roiGen, double thresholdFloorPercent = 50, double thresholdMult = 3)
    {
        FrameCount = roiGen.FrameCount;
        Rois = roiGen.Tracing.GetEvenlySpacedRois();
        Positions = Enumerable.Range(0, RoiCount).Select(x => (double)x * roiGen.Tracing.MicronsPerPixel).ToArray();
        Times = roiGen.FrameTimes;
        RedImages = Drawing.Crop(roiGen.RedImages, Rois);
        GreenImages = Drawing.Crop(roiGen.GreenImages, Rois);
        MergedImages = Drawing.GetMergedImages(RedImages, GreenImages);
        SortedRedPixelsByFrame = ArrayOperations.GetSortedPixels(roiGen.RedImages);
        SortedRedPixelsByRoi = ArrayOperations.GetSortedPixels(RedImages);
        //NoiseFloorsByFrame = ArrayOperations.GetNoiseFloorsByFrame(SortedRedPixelsByFrame, thresholdFloorPercent);
        ThresholdsByFrame = ArrayOperations.GetThresholdsByFrame(SortedRedPixelsByFrame, thresholdFloorPercent, thresholdMult);

        bool maskDisabled = thresholdFloorPercent == 0 || thresholdMult == 0;
        (MaskImages, Masks) = Drawing.GetMaskImages(RedImages, ThresholdsByFrame, roiGen.Tracing.IsCircular, maskDisabled);

        RedMeans = ArrayOperations.GetMeans(RedImages, Masks);
        GreenMeans = ArrayOperations.GetMeans(GreenImages, Masks);
        Ratios = ArrayOperations.GetRatios(RedMeans, GreenMeans);

        RedCurveByFrame = ArrayOperations.GetCurveByFrame(RedMeans);
        GreenCurveByFrame = ArrayOperations.GetCurveByFrame(GreenMeans);
        RatioCurveByFrame = ArrayOperations.GetCurveByFrame(Ratios);
    }
}