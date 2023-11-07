using System.Formats.Asn1;

class Circle : Shape
{
    private double _LhRadius;

    public Circle (double LhRadius, string LhColor) : base (LhColor)
    {
        _LhRadius = LhRadius;
    }

    public override double GetArea()
    {
        return _LhRadius * _LhRadius * Math.PI;
    }
}