﻿namespace DendriteTracer.Core;

/// <summary>
/// Represents a path along a dendrite.
/// Contains scale information so it can generate evenly spaced/sized ROIs too.
/// </summary>
public class Tracing
{
    public readonly List<PixelLocation> Points = new();
    public int Count => Points.Count;
    public int Width { get; }
    public int Height { get; }
    public double MicronsPerPixel { get; }

    public bool IsCircular { get; set; } = true;
    public double Spacing_Px { get; set; } = 10;
    public double Radius_Px { get; set; } = 15;

    public double RoiSpacing_Microns
    {
        get => Spacing_Px * MicronsPerPixel;
        set => Spacing_Px = value / MicronsPerPixel;
    }

    public double RoiRadius_Microns
    {
        get => Radius_Px * MicronsPerPixel;
        set => Radius_Px = value / MicronsPerPixel;
    }

    private double RoiEdgeLength_Microns => RoiRadius_Microns * 2;

    public double RoiArea_Microns => IsCircular
        ? Math.PI * RoiRadius_Microns * RoiRadius_Microns
        : RoiEdgeLength_Microns * RoiEdgeLength_Microns;

    public Tracing(int width, int height, double micronsPerPixel)
    {
        Width = width;
        Height = height;
        MicronsPerPixel = micronsPerPixel;
    }

    public void Clear()
    {
        Points.Clear();
    }

    public void Add(float x, float y)
    {
        if (x < 0 || x >= Width || y < 0 || y >= Height)
            throw new ArgumentException("outside image area");

        Points.Add(new PixelLocation(x, y));
    }

    public void Add(PixelLocation pixel)
    {
        Add(pixel.X, pixel.Y);
    }

    public void AddRange(PixelLocation[] pixels)
    {
        foreach (PixelLocation pixel in pixels)
        {
            Add(pixel);
        }
    }

    public PixelLocation[] GetPixels()
    {
        return Points.ToArray();
    }

    public string GetPointsString()
    {
        return string.Join(", ", GetPixels().Select(p => $"({p.X}, {p.Y})"));
    }

    public Roi[] GetEvenlySpacedRois(float spacingPx, float radiusPx)
    {
        Spacing_Px = spacingPx;
        Radius_Px = radiusPx;
        return GetEvenlySpacedRois();
    }

    // TODO: obsolete these
    public Roi[] GetEvenlySpacedRois()
    {
        List<Roi> rois = new();

        double nextSetback = 0;

        for (int i = 1; i < Points.Count; i++)
        {
            (PixelLocation[] segmentPoints, double setback) = GetSubPoints(Points[i - 1], Points[i], Spacing_Px, nextSetback);
            nextSetback = setback;
            Roi[] segmentRois = segmentPoints.Select(pt => new Roi(pt.X, pt.Y, (float)Radius_Px, IsCircular)).ToArray();
            rois.AddRange(segmentRois);
        }

        // TODO: more clearly warn if ROIs in the middle are missing

        return rois.Where(RoiIsFullyInsideImage).ToArray();
    }

    private bool RoiIsFullyInsideImage(Roi roi)
    {
        if (roi.Left < 0)
            return false;
        if (roi.Right >= Width)
            return false;
        if (roi.Top < 0)
            return false;
        if (roi.Bottom >= Height)
            return false;
        return true;
    }

    /// <summary>
    /// Walk from point 1 to point 2 and place new subpoints along the way.
    /// The first subpoint will be set back by the given amount.
    /// The distance remaining between the last subpoint and point 2 is returned.
    /// </summary>
    private static (PixelLocation[] points, double nextSetback) GetSubPoints(PixelLocation pt1, PixelLocation pt2, double spacing, double setback)
    {
        double dx = pt2.X - pt1.X;
        double dy = pt2.Y - pt1.Y;
        double distanceBetweenPoints = Math.Sqrt(dx * dx + dy * dy);
        double angle = Math.Atan(dy / dx);
        if (dx < 0)
            angle += Math.PI;

        List<PixelLocation> points = new();
        double travelled = spacing - setback;
        while (travelled <= distanceBetweenPoints)
        {
            double x = pt1.X + travelled * Math.Cos(angle);
            double y = pt1.Y + travelled * Math.Sin(angle);
            points.Add(new((float)x, (float)y));
            travelled += spacing;
        }

        double interPointTotal = (points.Count - 1) * spacing;
        double totalDistanceTravelled = spacing - setback + interPointTotal;
        double nextSetback = distanceBetweenPoints - totalDistanceTravelled;

        return (points.ToArray(), nextSetback);
    }

    // TODO: file IO
}
