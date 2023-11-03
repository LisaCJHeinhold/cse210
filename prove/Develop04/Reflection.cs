using System;

class Reflection : Activity
{
    //reflection attribute
    private List<string> _LhQuestions;

    //reflection constructor
    public Reflection (string LhActivityName, string LhActivtyDescription, int LhActivityDuration, List<string> LhActivityPrompt, List<string> LhQuestions) : base (LhActivityName, LhActivtyDescription, LhActivityDuration, LhActivityPrompt)
    {
        _LhQuestions = LhQuestions;
        _LhActivityPrompt = LhActivityPrompt;
    }

    //this should be used to run the reflection activity in the runActivity in activty class
    public void RunReflectionActivty()
    {
        base.RunActivity();
        int i = GetRandomNumber(3);
        //Logic
       Console.WriteLine($"Prompt: {_LhActivityPrompt[i]}");

       for (int x = 1; x <= 3; x++)
       {
        Console.WriteLine($"Question: {x}");
        Thread.Sleep(2000);
       }
    }
}