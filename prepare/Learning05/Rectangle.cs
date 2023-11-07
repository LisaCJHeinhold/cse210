using System.Formats.Asn1;

class Rectangle : Shape
{
    private double _LhWidth;
    private double _LhHeight;

    public Rectangle (double LhWidth, double LhHeight, string LhColor) : base (LhColor)
    {
        _LhWidth = LhWidth;
        _LhHeight = LhHeight;
    }

    public override double GetArea()
    {
        return _LhWidth * _LhHeight;
    }
}