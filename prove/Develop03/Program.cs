//Name: Scripture Memorizer
//Purpose: This program will as the user to input a scripture reference and the scripture content, 
//it will also ask for the number of words they want to remove at one time. The program will then randomly remove the specified
//number of words each time the user presses enter until all the words are gone, then the program will end. The purpose is to provide the 
//user with a tool for memorizing scriptures by slowly removing words.
//Team: Lisa Heinhold, Kaden Hansen, Joshua Pyle, Emma Shurtliff, Adam Schwartz, and Olivia Smart.
//Date: 10/21/2023


using System;

class Program {
        static void Main(string[] args)
    {   
        // Welcoming the user to the program
        Console.WriteLine("Welcome to the scripture memorizer program!");
        Console.WriteLine("Follow the instructions below: ");
        Console.WriteLine();

        // Asking the user for the scripture reference.
        Console.Write("Enter the reference of the scripture you want to memorize (ex. '1 Nephi 2:15'): ");
        string khReference = Console.ReadLine();

      
    

        // Asking user for the scriptire passage.
        Console.Write("Enter the scripture passage (ex. 'And my father dwelt in a tent.'): ");
        string khPassage = Console.ReadLine();

        

        // Ask the user for the number of words hidden each time they press enter.
        Console.Write("Specify the hidden word count for each memorization round. (ex. '3'): ");
        string khHiddenWordCount = Console.ReadLine();
        int khNumberHiddenWords = int.Parse(khHiddenWordCount);

        // Pass information to finished Memorizer class method here.
        Memorizer khMainMemorizer = new Memorizer(khReference, khPassage, khNumberHiddenWords);
        Console.Clear();
        Console.Write("Commit this to memory: \n");
        Console.WriteLine(khMainMemorizer.ToString());

        do{
            Console.Write("Press any key to continue or 'q' to quit: ");
            ConsoleKeyInfo khKeyInfo = Console.ReadKey(true); // Read a key without displaying it.
            if (khKeyInfo.Key == ConsoleKey.Q){
                break;
            }
            else {
                Console.Clear();
                khMainMemorizer.EesUpdateVerse();
                Console.WriteLine("Commit this to memory: ");
                Console.WriteLine(khMainMemorizer.ToString());
            }
        }while (khMainMemorizer.IsDone() == false);
        if (khMainMemorizer.IsDone() == true) {
            Console.WriteLine("\nThe word(s) are gone! If you can't recite the scripture(s) from memory, don't be afraid to try again!");
        }
        else {
            Console.WriteLine("\nQuitting the program..");
        }

    }
}
