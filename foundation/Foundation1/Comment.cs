using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Comment
{
    private string _name;
    private string _text;

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;  

    }

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetText()
    {
        return _text;
    }
    public void SetText(string text)
    {
        _text = text;
    }

    //_____________Method__________
    public void DisplayComment()
    {
        System.Console.WriteLine($"Comment:{_text} \nby {_name}");
    }
    
}

