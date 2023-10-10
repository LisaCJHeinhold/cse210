public class LhFraction
{
    private int _LhTop;
    private int _LhBottom;

    public LhFraction()
    {
        _LhTop = 1;
        _LhBottom = 1;
    }
    public LhFraction(int LhTop)
    {
        _LhTop = LhTop;
        _LhBottom = 1;
    }
    public LhFraction(int LhTop, int LhBottom)
    {
        _LhTop = LhTop;
        _LhBottom = LhBottom;
    }
    public string LhGetFractionString()
    {
        string LhOutput = $"{_LhTop}/{_LhBottom}";
        return LhOutput;
    }
    public double LhGetDecimalValue()
    {
        return (double)_LhTop / (double)_LhBottom;
    }
}