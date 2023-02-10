using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction fraction = new Fraction(15,45);
        Console.WriteLine(fraction.GetFractionToString());
        Console.WriteLine(fraction.GetDecimalValue());
    }    
}