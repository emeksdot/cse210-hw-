using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Application.");
        // string option = "start";
        DirectoryInfo currDir = new DirectoryInfo(".");
        System.Console.WriteLine(currDir.FullName);

        PromptGenerator pg = new PromptGenerator();
        Entry newEnt = new Entry();
        Journal newJournal = new Journal();
        newJournal._entries = new List<Entry>();

        Console.WriteLine("Choose an option from the following menu: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load ");
        Console.WriteLine("4. Save ");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        Console.Write(">>> ");
        string? option = Console.ReadLine();

        while (option != "")
        {
            if (option == "1")
            {
                newEnt._date = DateTime.Now.ToShortDateString();
                newEnt._promptText = pg.GetRandomPrompt();

                Console.WriteLine(newEnt._promptText);
                newEnt._entryText = Console.ReadLine();

                Console.WriteLine();
                newEnt.Display();
                newJournal._entries.Add(newEnt);
                if (!File.Exists("journal.txt"))
                {
                    using (StreamWriter writer = File.AppendText("journal.txt"))
                    {
                        writer.WriteLine(newEnt._date);
                        writer.WriteLine(newEnt._promptText);
                        writer.WriteLine(newEnt._entryText);
                        writer.WriteLine();
                    }
                }
                else
                {
                    using (StreamWriter writer = File.AppendText("journal.txt"))
                    {
                        writer.WriteLine(newEnt._date);
                        writer.WriteLine(newEnt._promptText);
                        writer.WriteLine(newEnt._entryText);
                        writer.WriteLine();
                    }
                }
            }
            else if (option == "2")
            {
                using (StreamReader reader = new StreamReader("journal.txt"))
                {
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
            else if (option == "3")
            {
                System.Console.WriteLine("What file do you want to load? ");
                string? file = Console.ReadLine();
                using (StreamReader reader = new StreamReader(file))
                {
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
            else if (option == "4")
            {
                newEnt._date = DateTime.Now.ToShortDateString();
                newEnt._promptText = pg.GetRandomPrompt();

                Console.WriteLine(newEnt._promptText);
                newEnt._entryText = Console.ReadLine();
                System.Console.WriteLine("Create a file with a .txt extension");
                string? fileName = Console.ReadLine();
                // FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);

                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine(newEnt._date);
                    writer.WriteLine(newEnt._promptText);
                    writer.WriteLine(newEnt._entryText);
                    // writer.
                }
            }
            else if (option == "5")
            {
                break;
            }
            Console.WriteLine("Choose an option from the following menu: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load ");
            Console.WriteLine("4. Save ");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            Console.Write(">>> ");
            option = Console.ReadLine();
        }
    }
}
