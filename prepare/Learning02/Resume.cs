public class LhResume
{
    public string _lhname;
    public List<LhJob> _lhjobs = new List<LhJob>();

    public void LhDisplayResume()
    {
        Console.WriteLine($"Name: {_lhname}");
        Console.WriteLine($"Jobs:");
        foreach (LhJob lhjob in _lhjobs)
        {
            lhjob.LhDisplayJobDetails();
        }
    }
}