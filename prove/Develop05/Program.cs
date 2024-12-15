using System;

class Program
{
    static void Main(string[] args)
    {
        // string option = Console.ReadLine();

        // while (option != "4")
        // {
        //     if (option == "1")
        //     {
        //         System.Console.WriteLine("Welcome to the Breathing Activity.");
        //         System.Console.WriteLine();
        //         System.Console.WriteLine(
        //             "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
        //         );

        //         System.Console.WriteLine();
        //         System.Console.WriteLine(
        //             "How long, in seconds would you like for your session to last? "
        //         );
        //         int durationBreathing = Convert.ToInt32(Console.ReadLine());

        //         BreathingActivity brAct = new BreathingActivity(
        //             "Breathing",
        //             "Breathing Exercise",
        //             durationBreathing
        //         );

        //         Console.Clear();
        //         System.Console.WriteLine("Get ready...");

        //         // for (int i = 0; i < duration; i++)
        //         // {
        //         //     // System.Console.Write($"{i}\b\b");
        //         //     Thread.Sleep(1000);
        //         // }


        //     }
        //     else if (option == "2")
        //     {
        //         System.Console.WriteLine();
        //         System.Console.WriteLine("Welcome to the Reflecting Activity.");
        //         System.Console.WriteLine();
        //         System.Console.WriteLine(
        //             "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
        //         );
        //         System.Console.WriteLine();
        //         System.Console.WriteLine(
        //             "How long, in seconds would you like for your session to last? "
        //         );

        //         int durationReflecting = Convert.ToInt32(Console.ReadLine());
        //         ReflectingActivity refAct = new ReflectingActivity(
        //             "Reflecting",
        //             "Meditation exercise",
        //             durationReflecting
        //         );

        //         Console.Clear();
        //         System.Console.WriteLine("Get ready...");
        //         System.Console.WriteLine();
        //         System.Console.WriteLine("Consider the following prompt: ");

        //         //______Call Prompts______
        //     }
        //     else if (option == "3")
        //     {
        //         System.Console.WriteLine("Welcome to the Listing Activity.");
        //         System.Console.WriteLine();
        //         System.Console.WriteLine(
        //             "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
        //         );
        //         System.Console.WriteLine();
        //         System.Console.WriteLine(
        //             "How long, in seconds would you like for your session to last? "
        //         );
        //         int durationListing = Convert.ToInt32(Console.ReadLine());
        //         ListingActivity listAct = new ListingActivity(
        //             "Listing",
        //             "Respond to prompts",
        //             durationListing,
        //             4
        //         );

        //         Console.Clear();
        //         System.Console.WriteLine("Get ready...");
        //         System.Console.WriteLine();
        //         System.Console.WriteLine(
        //             "List as many responses you can to the folllowing prompt: "
        //         );
        //         //_______Responses to follow_____________
        //     }
        //     break;
        // }
        // System.Console.WriteLine("Hello WorldCCC");
        // BreathingActivity breathAct = new BreathingActivity("Lalas", "May Day", 15);
        // breathAct.DisplayStartingMessage();

        System.Console.WriteLine("Menu Options:");
        System.Console.WriteLine(@"   1. Start breathing activity");
        System.Console.WriteLine(@"   2. Start reflecting activity");
        System.Console.WriteLine(@"   3. Start listing activity");
        System.Console.WriteLine(@"   4. Quit");
        System.Console.Write("Select a choice from the menu: ");

        string option = Console.ReadLine();

        while (option != "4")
        {
            if (option == "1")
            {
                Console.Clear();
                System.Console.WriteLine("Welcome to the Breathing Activity.");
                System.Console.WriteLine();
                System.Console.WriteLine(
                    "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
                );

                System.Console.WriteLine();
                System.Console.WriteLine(
                    "How long, in seconds would you like for your session to last? "
                );
                int brDuration = Convert.ToInt32(Console.ReadLine());

                string brName = "Breathing";
                string brDesc =
                    "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

                BreathingActivity breathAct = new BreathingActivity(brName, brDesc, brDuration);

                Console.Clear();
                System.Console.WriteLine("Get ready...");
                System.Console.WriteLine();
                System.Console.WriteLine();

                DateTime startTime = DateTime.Now;
                DateTime futureTime = startTime.AddSeconds(brDuration);
                DateTime currentTime = DateTime.Now;
                while (currentTime < futureTime)
                {
                    breathAct.Run();
                    Thread.Sleep(10000);
                    currentTime = DateTime.Now;
                }

                break;
            }
            else if (option == "2")
            {
                Console.Clear();
                System.Console.WriteLine("Welcome to the Reflecting Activity.");
                System.Console.WriteLine();
                System.Console.WriteLine(
                    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
                );
                System.Console.WriteLine();
                System.Console.WriteLine(
                    "How long, in seconds would you like for your session to last?"
                );

                int refDuration = Convert.ToInt32(Console.ReadLine());

                string refName = "Reflecting";
                string refDesc =
                    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

                ReflectingActivity refAct = new ReflectingActivity(refName, refDesc, refDuration);

                // Console.Clear();
                System.Console.WriteLine("Get ready...");
                System.Console.WriteLine();
                System.Console.WriteLine();

                DateTime startTime = DateTime.Now;
                DateTime futureTime = startTime.AddSeconds(refDuration);
                DateTime currentTime = DateTime.Now;
                while (currentTime < futureTime)
                {
                    refAct.Run();
                    Thread.Sleep(1000);
                    currentTime = DateTime.Now;
                }

                refAct.DisplayEndingMessage();
                break;
                // refAct.Run();
            }
            else if (option == "3") 
            {
                 System.Console.WriteLine("Welcome to the Listing Activity.");
                System.Console.WriteLine();
                System.Console.WriteLine(
                    "This activity will help you reflect on the good things in your life by having you list many things as you can in a certain area."
                );
                System.Console.WriteLine();
                System.Console.WriteLine(
                    "How long, in seconds would you like for your session to last?"
                );
                int listDuration = Convert.ToInt32(Console.ReadLine());

                ListingActivity listAct = new ListingActivity("Listing", "Reflect by listing", listDuration);

             }
            else
            {
                break;
            }
        }
    }
}
