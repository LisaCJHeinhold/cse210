using System;

class Reflection : Activity
{
    //reflection attribute
    private List<string> _LhQuestions;

    //reflection constructor
    public Reflection (string LhActivityName, string LhActivtyDescription, int LhActivityDuration, List<string> LhActivityPrompt, List<string> LhQuestions) : base (LhActivityName, LhActivtyDescription, LhActivityDuration, LhActivityPrompt)
    {
        _LhQuestions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        _LhActivityPrompt = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
    }

    //this should be used to run the reflection activity in the runActivity in activty class
    public void RunReflectionActivty()
    {
        base.StartingMessage();
        base.SetDuration();
        //Logic
        running = true;
        do
        {
            int i = GetRandomNumber(3);
            Console.WriteLine($"Prompt: {_LhActivityPrompt[i]}");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            foreach (string question in _LhQuestions)
                {
                    Console.WriteLine(question);
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }
        } while (running);
    }
    public void EndReflectionActivity()
    {
        base.EndingMessage();
    }
}