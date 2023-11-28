// Lisa Heinhold
// 12/9/2023
// Description: This is the main program for the FinalProject. This project is a Personality Quiz
// that will ask the user a series of questions and then give them a result based on their answers.

using System;

class Program
{
    static void Main(string[] args)
    {
        
    }
    static void StartingMessage()
    {
        Console.WriteLine("Welcome to the Personality Quiz!");
        Console.WriteLine("This quiz will ask you a series of questions and then give you a result based on your answers.");
        Console.WriteLine("Please read and follow the individual instructions for each question.");
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
    }
    static void EndingMessage()
    {
        Console.WriteLine("Thank you for taking the Personality Quiz!");
        Console.WriteLine("Press enter to exit.");
        Console.ReadLine();
    }
}