namespace Lab09;

public class Rectangle : AbstractGraphic2D
{
    public decimal Left;
    public decimal Top;
    public decimal Width;
    public decimal Height;

    public override decimal LowerBoundX => - 1;
    public override decimal UpperBoundX => + 1;
    public override decimal LowerBoundY => - 1;
    public override decimal UpperBoundY => + 1;

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
