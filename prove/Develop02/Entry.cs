using System;
using System.Collections.Generic;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.Write($"{_date} - ");
        Console.WriteLine($"{_promptText}");
        Console.WriteLine($"{_entryText}");
    }
    
}