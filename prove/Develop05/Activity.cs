using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    //____________Name___________
    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    //_________Description________
    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    //__________Duration____________
    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    //______Methods________
    public virtual void DisplayStartingMessage()
    {
        Console.WriteLine("Hello Develop05 World!");
    }

    public void DisplayEndingMessage()
    {
        System.Console.WriteLine("You have completed the activity.");
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            System.Console.Write($".| \b\b\b\b");
            Thread.Sleep(75);
            System.Console.Write("\b \b");
            System.Console.Write($".\\ \b\b\b\b");
            Thread.Sleep(75);
            System.Console.Write("\b \b");
            System.Console.Write($".- \b\b\b\b");
            Thread.Sleep(75);
            System.Console.Write("\b \b");
            System.Console.Write($"./ \b\b\b\b");
            Thread.Sleep(75);
            System.Console.Write("\b \b");
            System.Console.Write($".| \b\b\b\b");
            Thread.Sleep(75);
            System.Console.Write("\b \b");
            System.Console.Write($".\\ \b\b\b\b");
            Thread.Sleep(75);
            System.Console.Write("\b \b");
            System.Console.Write($".- \b\b\b\b");
            Thread.Sleep(75);
            System.Console.Write("\b \b");
            System.Console.Write($"./ \b\b\b\b");
            Thread.Sleep(75);
            System.Console.Write("\b \b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        while (seconds > 0)
        {
            System.Console.Write(seconds);
            Thread.Sleep(1000);
            System.Console.Write("\b \b");
            seconds--;
        }
    }
}
