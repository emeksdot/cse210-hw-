using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string name = PromptUserName();
        int favNumber = PromptUserNumber();
        SquareNumber(favNumber);
        DisplayResult(name, favNumber);
    }
    

    // DisplayWelcome - Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        System.Console.WriteLine("Welcome to the Program!");
    }

    // PromptUserName - Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        System.Console.WriteLine("Please enter your first name: ");
        string userName = System.Console.ReadLine();
        return userName;
    }

    // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        System.Console.WriteLine("Enter your favorite number as an integer: ");
        int userNumber = Convert.ToInt32(System.Console.ReadLine());
        return userNumber;
    }

    // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int value)
    {
        return value * value;
    }

    // DisplayResult - Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string nameOfPerson, int numberForPerson)
    {
        System.Console.WriteLine($"Your name is {nameOfPerson} and your favorite integer is {numberForPerson}.");
    }


}