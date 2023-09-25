using System;

class Program
{
    static void Main(string[] args)
    {
        LhJob lhjob1 = new LhJob();
        lhjob1._lhjobTitle = "Technology Support Engineer";
        lhjob1._lhcompany = "BYUI";
        lhjob1._lhstartYear = 2023;
        lhjob1._lhendYear = 2024;

        LhJob lhjob2 = new LhJob();
        lhjob2._lhjobTitle = "Server";
        lhjob2._lhcompany = "Olive Garden";
        lhjob2._lhstartYear = 2022;
        lhjob2._lhendYear = 2022;

        LhResume lhresume = new LhResume();
        lhresume._lhname = "Lisa Heinhold";
        lhresume._lhjobs.Add(lhjob1);
        lhresume._lhjobs.Add(lhjob2);

        lhresume.LhDisplayResume();
    }
}