using System.Data.Common;

namespace Lab09;

public class Circle : AbstractGraphic2D
{
    public decimal CenterX;
    public decimal CenterY;
    public decimal Radius;
    public Circle(decimal x, decimal y, decimal radius)
    {
        CenterX = x;
        CenterY = y;
        Radius = radius;
    }
    public override decimal LowerBoundX => -1;

    public override decimal UpperBoundX => -1;

    public override decimal LowerBoundY => -1;

    public override decimal UpperBoundY => -1;

    public override bool ContainsPoint(decimal x, decimal y)
    {
        return false;
    }
}