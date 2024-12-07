using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");
        Assignment assg1 = new Assignment("Lalas Alexis", "Maths");
        // System.Console.WriteLine(assg1.GetSummary());

        //string studentName, string topic, string textbookSection, string problems

        MathAssignment mathassg1 = new MathAssignment("Lalas Marino", "Fractions", "Section 7.3", "Problems 8 - 19");
        System.Console.WriteLine(mathassg1.GetSummary());
        System.Console.WriteLine(mathassg1.GetHomeworkList());

        WrtingAssignment wassg1 = new WrtingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");

        System.Console.WriteLine(wassg1.GetSummary());
        System.Console.WriteLine(wassg1.GetWritingInformation());
    }
}