using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string value = Console.ReadLine();
        float grade = float.Parse(value);
        char letter;

        if (grade >= 90)
        {
            letter = 'A';
            
        }
        else if (grade >= 80)
        {
            letter = 'B';
        }
        else if (grade >= 70)
        {
            letter = 'C';
        }
        else if (grade >= 60)
        {
            letter = 'D';
        }
        else 
        {
            letter = 'F';
        }
        Console.WriteLine(letter);
        if(grade >= 70)
        {
            Console.WriteLine("Congratulations, you have passed the Course!");
        } else
        {
            Console.WriteLine("So sorry you did not pass the course. Better luck next time.");
        }
    }
}