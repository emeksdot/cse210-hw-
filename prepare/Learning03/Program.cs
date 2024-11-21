using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction fr = new Fraction();
        Fraction fr2 = new Fraction(5);
        Fraction fr3 = new Fraction(3,4);
        Fraction fr4 = new Fraction(1,3);
        System.Console.WriteLine(fr.GetFractionString());
        System.Console.WriteLine(fr.GetDecimalValue());
        System.Console.WriteLine();
        System.Console.WriteLine(fr2.GetFractionString());
        System.Console.WriteLine(fr2.GetDecimalValue());
        System.Console.WriteLine();
        System.Console.WriteLine(fr3.GetFractionString());
        System.Console.WriteLine(fr3.GetDecimalValue());
        System.Console.WriteLine();
        System.Console.WriteLine(fr4.GetFractionString());
        System.Console.WriteLine(fr4.GetDecimalValue());
    }
}