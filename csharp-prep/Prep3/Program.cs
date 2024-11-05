using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");
        int magicNumber = 5;
        Console.WriteLine("Guess a number: ");
        string response = Console.ReadLine();
        int responeNumber = int.Parse(response);

        if (responeNumber > magicNumber)
        {
            Console.WriteLine("Your guess is higher.");
        }
        if (responeNumber < magicNumber)
        {
            Console.WriteLine("Your guess is lower.");
        }
        if (responeNumber == magicNumber)
        {
            Console.WriteLine("Your guess is correct.");
        }
    }
}