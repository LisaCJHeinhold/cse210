using System;

class Breathing : Activity
{
    //set up attrbutes that only apply to breathing activity
    private string _LhBreathIn;
    private string _LhBreathOut;
    private int _LhPause;

    //constructor for breathing
    public Breathing (string LhActivityName, string LhActivtyDescription, int LhActivityDuration, List<string> LhActivityAnimation, string LhBreathIn, string LhBreathOut, int LhPause) : base(LhActivityName, LhActivtyDescription, LhActivityDuration, LhActivityAnimation)
    {
        _LhBreathIn = LhBreathIn;
        _LhBreathOut = LhBreathOut;
        _LhPause = LhPause;
    }

    //this should be used to run the breathing activity in the runActivity in activty class
    public void RunBreathingActivty()
    {
        base.StartingMessage();
        //Logic
        base.SetDuration();
        SetPause();
        // Set running to true before entering the loop
        LhRunning = true;
        do
        {
            Console.WriteLine($"{_LhBreathIn}...");
            //Add a count down for their circular breathing
            CountDown();
            Console.WriteLine($"{_LhBreathOut}...");
            CountDown();
        } while (LhRunning);
    }
    public void EndBreathingActivity()
    {
        base.EndingMessage();
    }

    //this acks the user how long they want their breathing circulations to be and returns that number and sets it to _LhPause which is an attribute
    public int SetPause()
    {
        Console.WriteLine("Would you like to do breathing circulations of 4 or 7 seconds?");
        _LhPause = int.Parse(Console.ReadLine());
        return _LhPause;
    }

    //this funciton uses the returned _LhPause to create a count down that will play in runacitivty after each writeline breathin and breathout
    public void CountDown()
    {
        for (int i = _LhPause; i > 0; i--)
        {
            Console.WriteLine($"{i}");
            Thread.Sleep(1000);
        }
    }

}