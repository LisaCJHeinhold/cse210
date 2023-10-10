using System;

class Program
{
    static void Main(string[] args)
    {
        LhFraction LhOpt1 = new LhFraction();
        Console.WriteLine(LhOpt1.LhGetFractionString());
        Console.WriteLine(LhOpt1.LhGetDecimalValue());

        LhFraction LhOpt2 = new LhFraction(5);
        Console.WriteLine(LhOpt2.LhGetFractionString());
        Console.WriteLine(LhOpt2.LhGetDecimalValue());

        LhFraction LhOpt3 = new LhFraction(3, 4);
        Console.WriteLine(LhOpt3.LhGetFractionString());
        Console.WriteLine(LhOpt3.LhGetDecimalValue());    

        LhFraction LhOpt4 = new LhFraction(1, 3);
        Console.WriteLine(LhOpt4.LhGetFractionString());
        Console.WriteLine(LhOpt4.LhGetDecimalValue());    
    }
}