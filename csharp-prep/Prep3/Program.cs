//Lisa Heinhold 9/18/2023
//Description: Generater a random number and have the user guess what the number is when they guess respond with higher, lower, or you got it.
using System;
using System.Net.Mime;

class Program
{
    static void Main(string[] args)
    {
        Random lhrandomGenerate = new Random();
        int lhMagicNum = lhrandomGenerate.Next(1,100);

        int lhGuessNum = -999;

        while (lhGuessNum != lhMagicNum)
        {
            Console.Write("Guess what the magic number is. ");
            string lhGuessString = Console.ReadLine();
            lhGuessNum = int.Parse(lhGuessString);   
            if (lhGuessNum == lhMagicNum)
            {   
                Console.WriteLine("You Guessed It!");
            }
            else if (lhGuessNum > lhMagicNum) {
                Console.WriteLine("Lower");
            }
            else {
                Console.WriteLine("Higher");
            }
        }
    }
}