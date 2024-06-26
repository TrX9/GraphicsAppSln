using System.Drawing;

public abstract class BasicShape
{
    public Color FillColor { get; set; }
    public Color BorderColor { get; set; }
    public float BorderWidth { get; set; }

    public abstract float Width { get; protected set; }
    public abstract float Height { get; protected set; }

    public abstract void Draw(Graphics graphics);
    public abstract bool ContainsPoint(Point point);
}
