using System.Drawing;

public class RectangleShape : BasicShape
{
    public float X { get; set; }
    public float Y { get; set; }
    private float width;
    private float height;

    public override float Width
    {
        get
        {
            return width;
        }

        protected set
        {
            width = value;
        }
    }

    public override float Height
    {
        get => height;
        protected set => height = value;
    }

    public RectangleShape(float x, float y, float width, float height)
    {
        X = x;
        Y = y;
        Width = width;
        Height = height;
    }

    public override void Draw(Graphics graphics)
    {
        using (Brush brush = new SolidBrush(FillColor))
        using (Pen pen = new Pen(BorderColor, BorderWidth))
        {
            graphics.FillRectangle(brush, X, Y, Width, Height);
            graphics.DrawRectangle(pen, X, Y, Width, Height);
        }
    }

    public override bool ContainsPoint(Point point)
    {
        return (point.X >= X && point.X <= X + Width &&
                point.Y >= Y && point.Y <= Y + Height);
    }
}
