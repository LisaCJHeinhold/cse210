using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //call starting message
        LhStartingMessage();

        // Create instances of different question types
        MultipleChoice lhMcQuestion = new MultipleChoice("Multiple Choice", new List<string> { "In social situations, do you usually:" }, "Select one:", new List<string> { "Initiate conversations", "Wait for others to initiate conversations", "Avoid conversation", "Talk to as many people as possible" });
        lhMcQuestion.LhDisplayQuestion();
        lhMcQuestion.LhGetUserResponse();
        Console.Clear();
        TrueFalse lhTfQuestion = new TrueFalse("True False", new List<string> { "I enjoy attending large social gatherings." }, "Is this statement true (1) or false (2)?", new List<string>());
        lhTfQuestion.LhDisplayQuestion();
        lhTfQuestion.LhGetUserResponse();
        Console.Clear();
        Range lhRangeQuestion = new Range("Range", new List<string> { "On a scale from 1 to 4, how much do you enjoy spending time alone?" }, "Choose your preference:", new List<string>());
        lhRangeQuestion.LhDisplayQuestion();
        lhRangeQuestion.LhGetUserResponse();
        Console.Clear();
        MultipleResponse lhMrQuestion = new MultipleResponse("Multiple Response", new List<string> { "Choose the activities you find relaxing:" }, "Choose one or more:", new List<string> { "Attending parties", "Reading a book", "Going for a walk", "Meditating" });
        lhMrQuestion.LhDisplayQuestion();
        lhMrQuestion.LhGetUserResponse();
        Console.Clear();
        YesNoMaybe lhYnmQuestion = new YesNoMaybe("Yes No Maybe", new List<string> { "Can you easily adapt to new environments?" }, "Answer (Yes = 1, No = 2, Maybe = 3):", new List<string>());
        lhYnmQuestion.LhDisplayQuestion();
        lhYnmQuestion.LhGetUserResponse();
        Console.Clear();

        // Display ending message and calculate result
        List<Question> lhQuestions = new List<Question> { lhMcQuestion, lhTfQuestion, lhRangeQuestion, lhMrQuestion, lhYnmQuestion };
        Result.LhCalculatePersonality(lhQuestions);
        LhEndingMessage();

        Console.ReadLine();
    }

    static void LhStartingMessage()
    {
        Console.WriteLine("Welcome to the Personality Quiz!");
        Console.WriteLine("This quiz will ask you a series of questions and then give you a result based on your answers.");
        Console.WriteLine("Please read and follow the individual instructions for each question.");
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
    }

    static void LhEndingMessage()
    {
        Console.WriteLine("Thank you for taking the Personality Quiz!");
        Console.WriteLine("Press enter to exit.");
    }
}
