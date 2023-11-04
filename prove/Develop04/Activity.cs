using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Collections.Generic;
using System.Threading;
using System.Timers;

class Activity 
{
    //set up attributes for the activity class
    private string _LhActivityName;
    private string _LhActivityDescription;
    private int _LhActivityDuration;
    protected List<string> _LhActivityPrompt;
    private List<string> _LhActivityAnimation;

    //constructor for the activity class
    public Activity (string LhActivityName, string LhActivtyDescription, int LhActivityDuration, List<string>LhActivityAnimation)
    {
        _LhActivityName = LhActivityName;
        _LhActivityDescription = LhActivtyDescription;
        _LhActivityDuration = LhActivityDuration;
        _LhActivityAnimation = LhActivityAnimation;
    }

    //gets for each of the attributes
    public Activity (List<string> LhActivtyPrompt)
    {
        _LhActivityPrompt = LhActivtyPrompt;
    }
    // public string GetActivtyName()
    // {
    //     return _LhActivityName;
    // }
    // public string GetActivtyDescription()
    // {
    //     return _LhActivityDescription;
    // }
    // public int GetActivtyDuration()
    // {
    //     return _LhActivityDuration;
    // }
    // public List<string> GetActivtyPrompt()
    // {
    //     return _LhActivityPrompt;
    // }
    // public List<string> GetActivtyAnimation()
    // {
    //     return _LhActivityAnimation;
    // }
    // public void RunActivityLogic() 
    // {
    //     if (_LhActivityName == "Breathing")
    //     {

    //     } else if (_LhActivityName == "Reflection")
    //     {

    //     } else if (_LhActivityName == "Listing")
    //     {

    //     }
    // }

    // public void RunActivity()
    // {
    //     StartingMessage();
    //     // bool LhDuration = SetDuration();
    //     // if (_LhActivityPrompt != null){
    //     //     Console.WriteLine("Here is your prompt:");
    //     // }
    //     // while(LhDuration == true)
    //     // {
    //     //     RunActivityLogic();
           
    //     // }
    //     //logic for activities that could call each activity
    //     EndingMessage();
    // }

    //Starting method that need to run at the beginning of each specified activity
    public void StartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Let's start {_LhActivityName}.");
        Console.WriteLine($" {_LhActivityDescription}");
        // SetDuration();
        Console.Clear();
        Console.WriteLine("Get ready to begin...");
        RunAnimation(5);
    }

    //ending message that should run at the end of each specified activity
    public void EndingMessage()
    {
        Console.WriteLine($"Good job! You've completed {_LhActivityName}");
        RunAnimation(5);
        Console.WriteLine("Done.");
    }

    //sets the duration for the practice session, this should be set up in a while loop for each run activity in the program class (while SetDuration is true continue running the activity loop, while it is false end the activity)
public bool SetDuration()
{
    Console.Write("How long would you like to practice this activity? (Minutes): ");
    int LhTimeInput = int.Parse(Console.ReadLine());
    // int LhDuration = LhTimeInput * 60;
    var LhStartTime = DateTime.UtcNow;

    // Use TimeSpan.FromMinutes to convert the user input to seconds
    TimeSpan LhDuration = TimeSpan.FromMinutes(LhTimeInput);
    bool LhDurationBool;

    // Create a timer with the user input as the interval
    System.Timers.Timer timer = new System.Timers.Timer(LhDuration.TotalMilliseconds); // Change the type of the timer
    // Add an event handler to the timer
    timer.Elapsed += Timer_Elapsed;
    // Start the timer
    timer.Enabled = true;

    // Use a condition to check if the current time is less than the start time plus the duration
    if (LhStartTime < LhStartTime + LhDuration)
    {
        LhDurationBool = true;
        return LhDurationBool;
    }
    else
    {
        LhDurationBool = false;
        return LhDurationBool;
    }
}

// Define a flag variable to control the loop
protected bool running;

// Define the event handler for the timer
private void Timer_Elapsed(object sender, ElapsedEventArgs e)
{
    // Set the flag to false when the timer expires
    running = false;
}
    
    //this creates the animation that will run at the beginning and end of all the activitys
    public void RunAnimation(int time)
    {
        // for {int i = 5; i > 0; i--}
        // {
        //     Console.Write(".");
        //     Thread.Sleep(1000);
        // }
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(100);
            Console.Write("\b \b");
            
            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }

        // foreach (string s in animationStrings)
        // {
        //     Console.Write(s);
        //     Thread.Sleep(1000);
        //     Console.Write("\b \b");
        // }

    }

    //this function should contain all the logic to run each activity


    //this function gets a random number to choose reflections prompt and listings prompt at random
    public int GetRandomNumber(int max)
    {
        Random r = new Random();
        int LhRandomNum = r.Next(0, max);
        return LhRandomNum;
    }
}