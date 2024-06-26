using System.Drawing;

public class CircleShape : BasicShape
{
    public float X { get; set; }
    public float Y { get; set; }
    private float radius;

    public float Radius
    {
        get => radius;
        set
        {
            radius = value;
            Width = Height = radius * 2;
        }
    }

    public override float Width { get; protected set; }
    public override float Height { get; protected set; }

    public CircleShape(float x, float y, float radius)
    {
        X = x;
        Y = y;
        Radius = radius;
    }

    public override void Draw(Graphics g)
    {
        using (Brush brush = new SolidBrush(FillColor))
        using (Pen pen = new Pen(BorderColor, BorderWidth))
        {
            float diameter = 2 * Radius;
            g.FillEllipse(brush, X - Radius, Y - Radius, diameter, diameter);
            g.DrawEllipse(pen, X - Radius, Y - Radius, diameter, diameter);
        }
    }

    public override bool ContainsPoint(Point point)
    {
        float dx = point.X - X;
        float dy = point.Y - Y;
        return (dx * dx + dy * dy <= Radius * Radius);
    }
}
