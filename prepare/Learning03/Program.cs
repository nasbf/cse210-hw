using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction result = new Fraction();
        Console.WriteLine(result.GetFraction ());
        Console.WriteLine(result.GetDecimal ());

        Fraction result1 = new Fraction(8);
        Console.WriteLine(result1.GetFraction ());
        Console.WriteLine(result1.GetDecimal ());

        Fraction result2 = new Fraction(1, 3);
        Console.WriteLine(result2.GetFraction ());
        Console.WriteLine(result2.GetDecimal ());
    }
}