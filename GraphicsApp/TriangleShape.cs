using System;
using System.Drawing;

public class TriangleShape : BasicShape
{
    public PointF PointA { get; set; }
    public PointF PointB { get; set; }
    public PointF PointC { get; set; }

    private float width;
    private float height;

    public override float Width
    {
        get { return width; }
        protected set { width = value; }
    }

    public override float Height
    {
        get { return height; }
        protected set { height = value; }
    }

    public TriangleShape(PointF pointA, PointF pointB, PointF pointC)
    {
        PointA = pointA;
        PointB = pointB;
        PointC = pointC;
        CalculateDimensions();
    }

    private void CalculateDimensions()
    {
        width = Math.Max(PointA.X, Math.Max(PointB.X, PointC.X)) - Math.Min(PointA.X, Math.Min(PointB.X, PointC.X));
        height = Math.Max(PointA.Y, Math.Max(PointB.Y, PointC.Y)) - Math.Min(PointA.Y, Math.Min(PointB.Y, PointC.Y));
    }

    public override void Draw(Graphics graphics)
    {
        using (Brush brush = new SolidBrush(FillColor))
        using (Pen pen = new Pen(BorderColor, BorderWidth))
        {
            PointF[] points = { PointA, PointB, PointC };
            graphics.FillPolygon(brush, points);
            graphics.DrawPolygon(pen, points);
        }
    }

    public override bool ContainsPoint(Point point)
    {
        // Use Barycentric technique to check if the point is inside the triangle
        float denominator = ((PointB.Y - PointC.Y) * (PointA.X - PointC.X) + (PointC.X - PointB.X) * (PointA.Y - PointC.Y));
        float a = ((PointB.Y - PointC.Y) * (point.X - PointC.X) + (PointC.X - PointB.X) * (point.Y - PointC.Y)) / denominator;
        float b = ((PointC.Y - PointA.Y) * (point.X - PointC.X) + (PointA.X - PointC.X) * (point.Y - PointC.Y)) / denominator;
        float c = 1 - a - b;

        return (a >= 0) && (b >= 0) && (c >= 0);
    }
}
