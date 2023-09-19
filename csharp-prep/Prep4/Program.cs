//Lisa Heinhold 9/18/2023
//Description: have the user enter numbers (0 if they want to quit) each number will be added to a list. Give the sum of all the numbers, the average, and the largest number.
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int lhNum = -1;
        List<int> lhNumbers = new List<int>();
        while (lhNum != 0) 
        {
            Console.Write("Enter Number: ");
            string lhResponse = Console.ReadLine();
            lhNum = int.Parse(lhResponse);

            if (lhNum != 0)
            {
            lhNumbers.Add(lhNum);
            }
        }
        int lhSum = 0;
        foreach (int lhNumber in lhNumbers) 
        {
            lhSum += lhNumber;
        }
        Console.WriteLine($"The sum is: {lhSum}");
        float lhAverage = ((float)lhSum) / lhNumbers.Count;
        Console.WriteLine($"The average is: {lhAverage}");

        int lhMax = lhNumbers[0];
        foreach (int lhNumber in lhNumbers) 
        {
            if (lhNumber > lhMax)
            {
                lhMax = lhNumber;
            }
        }
        Console.WriteLine($"The largest number is: {lhMax}");
    }
}