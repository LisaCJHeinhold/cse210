public class LhJob 
{
    public string _lhjobTitle;
    public string _lhcompany;
    public int _lhstartYear;
    public int _lhendYear;
    public void LhDisplayJobDetails() 
    {
        Console.WriteLine($"{_lhjobTitle} ({_lhcompany}) {_lhstartYear}-{_lhendYear}");
    }
}