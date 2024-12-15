using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class ListingActivity : Activity
{
    private int _count;
    public List<string> _prompts;

    public ListingActivity(string name, string description, int duration, int count)
        : base(name, description, duration)
    {
        _count = 0;
        _prompts = new List<string>();
    }

    //__________Count_______________
    public int GetCount()
    {
        return _count;
    }

    public void SetCount(int count)
    {
        _count = count;
    }

    //__________Prompts____________
    public List<string> GetPrompts()
    {
        return _prompts;
    }

    public void SetPrompts(List<string> prompts)
    {
        _prompts = prompts;
    }

    //___________Methods____________
    public void Run()
    {
        ShowSpinner(6);
        _prompts.Add("---Who are those people that you deeply appreciate?---");
        _prompts.Add("---What are personal strengths of yours?---");
        _prompts.Add("---Who are people that you have helped this week?---");
        _prompts.Add("---When have you felt the Holy Ghost this month?---");
        _prompts.Add("---Who are some of your personal heroes?---");
        System.Console.WriteLine("List as many responses as you can to the following prompt:");


        GetRandomPrompt();
        System.Console.Write("You may begin in: \b");
        System.Console.WriteLine();
        ShowCountDown(5);
        System.Console.WriteLine();
        // GetListFromUser();
        System.Console.WriteLine($"You listed {GetListFromUser().Count} items.");
        DisplayEndingMessage();

    }

    public void GetRandomPrompt()
    {
        Random guessNum = new Random();
        int num = guessNum.Next(0, 5);
        System.Console.WriteLine(_prompts[num]);
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        string input = Console.ReadLine();

        while (!String.IsNullOrEmpty(input))
        {
            // System.Console.WriteLine(input);
            userList.Add(input);
            input = Console.ReadLine();
        }
        return userList;
    }

    public override void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed another {GetDuration()} seconds of the Listing activity."
        );
    }
}
