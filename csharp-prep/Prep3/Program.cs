using System;

class Program
{
    static void Main(string[] args)
    {


        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        int magicNumber = number;

        // Console.WriteLine(number);

        Console.WriteLine("Guess a number: ");
        string response = Console.ReadLine();
        int responeNumber = int.Parse(response);

        while (responeNumber != magicNumber)
        {
            
            if (responeNumber > magicNumber)
            {
                Console.WriteLine("Your guess is higher.");
            }
            if (responeNumber < magicNumber)
            {
                Console.WriteLine("Your guess is lower.");
            }
             response = Console.ReadLine();
             responeNumber = int.Parse(response);
        }
        if (responeNumber == magicNumber)
            {
                Console.WriteLine("Your guess is correct.");
            }
    }
}