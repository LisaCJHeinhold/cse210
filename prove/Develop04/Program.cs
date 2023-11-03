using System;
using System.Collections.Generic;

class Program
{
    static bool End()
    {
        // at the end of the chosen activity ask them if they want to practice another activity
        Console.WriteLine("Would you like to choose another activity? (yes or no) ");
        string LhUserResponse = Console.ReadLine();
        //if the user chooses yes to complete another acitvity run the program again, if no end the program
        if (LhUserResponse.ToLower() == "yes")
        {
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
            Console.WriteLine("Enter your choice: ");
            int LhChoice = int.Parse(Console.ReadLine());
            return LhChoice;
    }
    static void Main(string[] args)
    {
        bool end = true;
        int LhUserChoice = GetUserChoice();
        do {
            //depending on which activity the user wants to complete run the specific logic for that activty
            if (LhUserChoice == 1) {
                
            }
            else if (LhUserChoice == 2) {
                
            }
            else if (LhUserChoice == 3) {
                

            }

            end = End();
        } while (end == true);
    }
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
        Console.WriteLine("Enter any other key to Exit");
        Console.WriteLine("----------------------------------");

    }

    // public void RunActivity()
    // {
    //     // this function is what will end up running all the logic for the program
    //     //first call the menu 
    //     Menu();
    //     //call the GetUserChoice function and assign it to a variable
    //     int LhUserChoice = GetUserChoice();
    //     do {
    //         //depending on which activity the user wants to complete run the specific logic for that activty
    //         if (LhUserChoice == 1) {
    //             string LhActivtyDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    //         }
    //         else if (LhUserChoice == 2) {
    //             string LhActivtyDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

    //         }
    //         else if (LhUserChoice == 3) {
    //             string LhActivtyDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    //         }
            
    //     } while (end == true);
    // }
    
}
