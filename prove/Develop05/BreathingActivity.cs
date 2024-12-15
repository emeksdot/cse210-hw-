using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration)
        : base(name, description, duration) { }

    public void Run()
    {
        ShowSpinner(6);

        System.Console.Write("Breathe in...");
        ShowCountDown(4);
        System.Console.WriteLine();
        System.Console.Write("Breathe out...");
        ShowCountDown(6);
        System.Console.WriteLine();
        System.Console.WriteLine();
        System.Console.Write("Breathe in...");
        ShowCountDown(4);
        System.Console.WriteLine();
        System.Console.Write("Breathe out...");
        ShowCountDown(6);
        System.Console.WriteLine();
        System.Console.WriteLine();
        System.Console.Write("Breathe in...");
        ShowCountDown(4);
        System.Console.WriteLine();
        System.Console.Write("Breathe out...");
        ShowCountDown(6);
        System.Console.WriteLine();
        System.Console.WriteLine();
        System.Console.Write("Breathe in...");
        ShowCountDown(4);
        System.Console.WriteLine();
        System.Console.Write("Breathe out...");
        ShowCountDown(6);
        System.Console.WriteLine();
        System.Console.WriteLine();
        System.Console.Write("Breathe in...");
        ShowCountDown(4);
        System.Console.WriteLine();
        System.Console.Write("Breathe out...");
        ShowCountDown(6);
        System.Console.WriteLine();
        System.Console.WriteLine();
        DisplayEndingMessage();
        ShowSpinner(6);
        


    }

    public override void DisplayEndingMessage()
    {
        System.Console.WriteLine("Well done!!!");
        System.Console.WriteLine($"You completed {GetDuration()} seconds of the breathing activity.");
    }
}
