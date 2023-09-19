//Lisa Heinhold 9/18/2023
//Description: this program will write 5 functions, a welcome one, one to get user name, one to get user fav number, one to quare the number, and one to print a message telling the user what their fav number squared is.
using System;

class Program
{
    static void Main(string[] args)
    {
        lhDisplayWelcome();
        string lhUserName = lhPromptUserName();
        int lhUserNumber = lhPromptUserNumber();
        int lhSquaredNum = lhSquareNumber(lhUserNumber);
        lhDisplayResult(lhUserName, lhSquaredNum);
    }
    static void lhDisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string lhPromptUserName()
    {
        Console.Write("Please enter your name: ");
        string lhName = Console.ReadLine();
        return lhName;
    }
    static int lhPromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int lhNum = int.Parse(Console.ReadLine());
        return lhNum;
    }
    static int lhSquareNumber(int lhNum)
    {
        int lhSquare = lhNum * lhNum;
        return lhSquare;
    }
    static void lhDisplayResult(string lhName, int lhSquare)
    {
        Console.WriteLine($"{lhName}, the square of your number is {lhSquare}");
    }
}