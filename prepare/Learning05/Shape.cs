using System.Formats.Asn1;

public abstract class Shape 
{
    private string _color;

    public Shape (string LhColor)
    {
        _color = LhColor;
    }

    public string GetColor()
    {
        return _color;
    }

    public virtual void SetColor(string color)
    {
        _color = color;
    }
    public abstract double GetArea();
}