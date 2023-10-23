using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Lisa Heinhold", "Programming");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathAssignment1 = new MathAssignment("Michael Heinhold", "Programming", "8.1", "8-10");
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());

        WritingAssignment writingAssignment1 = new WritingAssignment("Joe Bob", "History", "History Stuff");
        Console.WriteLine(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());

    }
}