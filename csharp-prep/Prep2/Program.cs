using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string lhPercentInput = Console.ReadLine();
        float lhPercent = float.Parse(lhPercentInput);

        string lhLetter = "";

        if (lhPercent >= 90)
        {   
            lhLetter = "A";
        }
        else if (lhPercent >= 80 && lhPercent < 90)
        {
            lhLetter = "B";
        }
        else if (lhPercent >= 70 && lhPercent < 80)
        {
            lhLetter = "C";
        }
        else if (lhPercent >= 60 && lhPercent < 70)
        {
            lhLetter = "D";
        }
        else
        {
            lhLetter = "F";
        }

        Console.WriteLine($"Your grade is {lhLetter}.");

        if (lhPercent >= 70)
        {
            Console.WriteLine("Congratulations! You are passing your class!");
        }
        else
        {
            Console.WriteLine("You are failing your class. You need to work harder.");
        }
    }
}