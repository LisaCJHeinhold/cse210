// Lisa Heinhold 9/13/2023
//Description: This project will ask the user to input their first and last name. It will then write back "your name is {lastName}, {firstName} {lastName}.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string lhFirst = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lhLast = Console.ReadLine();

        Console.WriteLine($"Your name is {lhLast}, {lhFirst} {lhLast}.");
    }
}