using System.Formats.Asn1;

class Square : Shape
{
    private double _side;

    public Square (double LhSide, string LhColor) : base (LhColor)
    {
        _side = LhSide;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}