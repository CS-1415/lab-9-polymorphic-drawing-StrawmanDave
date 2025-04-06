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
    public override decimal LowerBoundX => CenterX - 2;

    public override decimal UpperBoundX => CenterX + 2;

    public override decimal LowerBoundY => CenterY - 2;

    public override decimal UpperBoundY => CenterY + 2;

    public override bool ContainsPoint(decimal x, decimal y)
    {
        if(CenterX == x && CenterY == y)
        {
            return true;
        }

        if(LowerBoundX == x && CenterY == y)
        {
            return true;
        }

        if(UpperBoundX == x && CenterY == y)
        {
            return true;
        }

        if(CenterX == x && LowerBoundY == y)
        {
            return true;
        }

        if(CenterX == x && UpperBoundY == y)
        {
            return true;
        }
        return false;
    }
}