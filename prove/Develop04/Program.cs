//Name: Mindfulness Program
//Purpose: The purpose of this program is to provide users with easy to use mindfullness activties.
//There are 3 activities the first is a breathing activity to help the user take a moment to take deep breaths.
//the second is a reflection activity to give the user an opportunity to reflect on a given prompt, with questions to assist.
//the last activity is a listing activity that gives the user the change to list things based on a prompt.
//Team: Lisa Heinhold
//Date: 11/04/2023

using System;
using System.Collections.Generic;

class Program
{
    static void Menu()
    {
        // print this menu when the program first runs so the user can choose which activity they want to do.
        Console.WriteLine("Hello, Welcome to the Mindfulness Program!");
        Console.WriteLine();
        Console.WriteLine("             Activities:            ");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Enter 1 for the Breathing Activity.");
        Console.WriteLine("Enter 2 for the Reflection Activity.");
        Console.WriteLine("Enter 3 for the Listing Activity.");
        Console.WriteLine("Enter 4 to Exit");
        Console.WriteLine("----------------------------------");

    }
    static bool End()
    {
        // at the end of the chosen activity ask them if they want to practice another activity
        Console.Write("Would you like to choose another activity? (yes or no) ");
        string LhUserResponse = Console.ReadLine();
        //if the user chooses yes to complete another acitvity run the program again, if no end the program
        if (LhUserResponse.ToLower() == "yes")
        {
            Main();
            return true;
        } else {
            Console.WriteLine("End Program.");
            Environment.Exit(1);
            return false;
        }
    }
    static int GetUserChoice()
    {
        // this program gets input from the user on which activity they want to complete
            Console.Write("Enter your choice: ");
            string LhInitialInput = Console.ReadLine();
            if (LhInitialInput == "1")
            {
                int LhChoice = int.Parse(LhInitialInput);
                return LhChoice;
            } else if (LhInitialInput == "2")
            {
                int LhChoice = int.Parse(LhInitialInput);
                return LhChoice;
            }else if (LhInitialInput == "3")
            {
                int LhChoice = int.Parse(LhInitialInput);
                return LhChoice;
            }else if (LhInitialInput == "4")
            {
                int LhChoice = int.Parse(LhInitialInput);
                return LhChoice;
            } else
            {
                Console.WriteLine("Invalid Input, Please enter: 1, 2, 3, or 4");
                Console.Write("Enter your choice: ");
                int LhChoice = int.Parse(Console.ReadLine());
                return LhChoice;
            }
    }
    static void Main()
    {
        Menu();
        int LhChoice = GetUserChoice();

        if (LhChoice == 1)
        {
            Breathing Breath = new Breathing("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0, new List<string> { "|", "/", "-", "\\" }, "Inhale", "Exhale", 3);
            Breath.RunBreathingActivty();
            Breath.EndBreathingActivity();
        } else if (LhChoice == 2)
        {
            Reflection Reflect = new Reflection("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0, new List<string>(), new List<string>());
            Reflect.RunReflectionActivty();
            Reflect.EndReflectionActivity();
        } else if (LhChoice == 3)
        {
            Listing List = new Listing("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0, new List<string>(), "");
            List.RunListingActivty();
            List.EndListingActivity();
        } else if (LhChoice == 4)
        {
            Console.WriteLine("End Program.");
            Environment.Exit(1);
        } else {
            Console.WriteLine("Invalid Input, try again..");
            GetUserChoice();
        }
        End();
    }
}