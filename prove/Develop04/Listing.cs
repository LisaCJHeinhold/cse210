using System;
using System.Runtime.InteropServices;
using System.Text;

class Listing : Activity
{
    //listing attribute
    private string _LhListingInput;

    //listing constructor
    public Listing (string LhActivityName, string LhActivtyDescription, int LhActivityDuration, List<string> LhActivityPrompt, string LhListingInput) : base (LhActivityName, LhActivtyDescription, LhActivityDuration, LhActivityPrompt)
    {
        _LhActivityPrompt = new List<string> 
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        _LhListingInput = LhListingInput;
    }

    //this should be used to run the listing activity in the runActivity in activty class
    public void RunListingActivty()
    {
        base.StartingMessage();
        bool LhDuration = base.SetDuration();
        int i = GetRandomNumber(4);
        // Create a StringBuilder object to store the user input
        StringBuilder LhString = new StringBuilder();
        //Logic
        running = true;
        Console.WriteLine($"Prompt: {_LhActivityPrompt[i]}");
        Console.WriteLine("You have a few seconds to start thinking...");
        base.RunAnimation(5);
        Console.WriteLine("Now, start listing!");
        do
        {
            Console.Write(">");
            string _LhListingInput = Console.ReadLine();
            // Append the user input to the StringBuilder object
            LhString.AppendLine(_LhListingInput);
        } while (running);
        Console.Clear();
        Console.WriteLine(LhString.ToString());
    }
    public void EndListingActivity()
    {
        base.EndingMessage();
    }
}