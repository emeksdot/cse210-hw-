using System;

class Program
{
    static void Main(string[] args)
    {
         string str76 = "Also, I give unto you a commandment that ye shall continue in prayer and fasting from this time forth.";
        string str77 = "And I give unto you a commandment that you shall teach one another the doctrine of the kingdom.";

        Reference newRef = new Reference("Doctrine and Covenants", 88, 76);
        Reference newRef2 = new Reference("Doctrine and Covenants", 88, 76, 77);
        
        string str2 = str76 + " " + str77;
        Scripture newScript = new Scripture(newRef, str76);
        Scripture newScript2 = new Scripture(newRef, str2);




        Console.WriteLine("Choose an option");
        System.Console.Write(newRef2.GetDisplayText() + " ");
        System.Console.WriteLine(newScript2.GetDisplayText());
        Console.WriteLine($"Press enter to continue or type 'quit' to finish" );
        var option = Console.ReadLine();
        option = option.ToLower();
        while (option != "quit")
        {
            // System.Console.Write(newRef2.GetDisplayText() + " ");
            newScript2.HideRandomWords(3);
            System.Console.Write(newRef2.GetDisplayText() + " ");
            System.Console.WriteLine(newScript2.GetDisplayText());
            Console.WriteLine($"Press enter to continue or type 'quit' to finish" );
            option = Console.ReadLine();
            option = option.ToLower();
            string[] temp3 = newScript2.GetDisplayText().Split(" ");
            
        }
    }
}