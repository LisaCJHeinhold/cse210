using System;
using System.Runtime.InteropServices;

class Listing : Activity
{
    //listing attribute
    private string _LhListingInput;

    //listing constructor
    public Listing (string LhActivityName, string LhActivtyDescription, int LhActivityDuration, List<string> LhActivityPrompt, string LhListingInput) : base (LhActivityName, LhActivtyDescription, LhActivityDuration, LhActivityPrompt)
    {
        _LhActivityPrompt = LhActivityPrompt;
        _LhListingInput = LhListingInput;
    }

    //this should be used to run the listing activity in the runActivity in activty class
    public void RunListingActivty()
    {
        base.RunActivity();
        int i = GetRandomNumber(4);
        //Logic
        Console.WriteLine($"Prompt: {_LhActivityPrompt[i]}");
        Console.WriteLine("You have a few seconds to start thinking...");
        Thread.Sleep(5000);
        Console.WriteLine("Now, start listing!");
        Console.Write(">");
        string _LhListingInput = Console.ReadLine();
        Console.Clear();
        Console.WriteLine(_LhListingInput);
    }
}