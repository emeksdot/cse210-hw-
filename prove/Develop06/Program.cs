using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop06 World!");
        GoalManager gm = new GoalManager();
        gm.Start();
        Console.WriteLine("Menu Options:");
        Console.WriteLine(@"   1. Create New Goal");
        Console.WriteLine(@"   2. List Goals");
        Console.WriteLine(@"   3. Save Goals");
        Console.WriteLine(@"   4. Load Goals");
        Console.WriteLine(@"   5. Record Event");
        Console.WriteLine(@"   6. Quit");
        Console.Write("Select a choice from the menu: ");

        string menuOption = Console.ReadLine();

        while (menuOption != "")
        {
            if (menuOption == "1")
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine(@"   1. Simple Goal");
                Console.WriteLine(@"   2. Eternal Goal");
                Console.WriteLine(@"   3. CheckList Goal");
                Console.Write("Which type of goal would you like to create? ");
                string goalOption = Console.ReadLine();

                if (goalOption == "1")
                {
                    Console.Write($"What is the name of your goal?>>> ");
                    string name = Console.ReadLine();
                    Console.Write($"What is a short description of it?>>> ");
                    string description = Console.ReadLine();
                    Console.Write($"What is the amount of points associated with this goal?>>> ");
                    string points = Console.ReadLine();
                    SimpleGoal sg = new SimpleGoal(name, description, points);
                    gm.CreateGoal(sg);
                    // break;
                    // gm.Start();
                }
                else if (goalOption == "2")
                {
                    Console.Write($"What is the name of your goal?>>> ");
                    string name = Console.ReadLine();
                    Console.Write($"What is a short description of it?>>> ");
                    string description = Console.ReadLine();
                    Console.Write($"What is the amount of points associated with this goal?>>> ");
                    string points = Console.ReadLine();
                    EternalGoal eg = new EternalGoal(name, description, points);
                    gm.CreateGoal(eg);
                }
                else if (goalOption == "3")
                {
                    Console.Write($"What is the name of your goal?>>> ");
                    string name = Console.ReadLine();
                    Console.Write($"What is a short description of it?>>> ");
                    string description = Console.ReadLine();
                    Console.Write($"What is the amount of points associated with this goal?>>> ");
                    string points = Console.ReadLine();
                    Console.Write($"How many times does this goal need to be accomplished?>>> ");
                    int target = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"What is the bonus for accomplishing it that many times?>>> ");
                    int bonus = Convert.ToInt32(Console.ReadLine());
                    CheckListGoal clg = new CheckListGoal(name, description, points, target, bonus);
                    gm.CreateGoal(clg);
                    // break;
                    // gm.Start();
                }
            }
            else if (menuOption == "2")
            {
                gm.ListGoalDetails();
            }
            else if (menuOption == "3") { }
            else if (menuOption == "4") { }
            else if (menuOption == "5") { }
            else if (menuOption == "6")
            {
                break;
            }
            Console.WriteLine("Menu Options:");
            Console.WriteLine(@"   1. Create New Goal");
            Console.WriteLine(@"   2. List Goals");
            Console.WriteLine(@"   3. Save Goals");
            Console.WriteLine(@"   4. Load Goals");
            Console.WriteLine(@"   5. Record Event");
            Console.WriteLine(@"   6. Quit");
            Console.Write("Select a choice from the menu: ");
            menuOption = Console.ReadLine();

            // gm.Start();
        }
    }
}
