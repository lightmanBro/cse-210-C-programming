using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction fraction = new Fraction(15,45);
        string txt = fraction.GetFractionToString();
        Console.WriteLine(txt);
        Console.WriteLine(fraction.GetDecimalValue());
    }    
}