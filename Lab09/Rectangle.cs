namespace Lab09;

public class Rectangle : AbstractGraphic2D
{
    public decimal Left;
    public decimal Top;
    public decimal Width;
    public decimal Height;

    public override decimal LowerBoundX => Left;
    public override decimal UpperBoundX => Left + Width;
    public override decimal LowerBoundY => Top;
    public override decimal UpperBoundY => Top + Height;

    public Rectangle(decimal left, decimal top, decimal width, decimal height)
    {
        Left = left;
        Top = top;
        Width = width;
        Height = height;
    }

    public override bool ContainsPoint(decimal x, decimal y)
    {
        return false;
    }
}
