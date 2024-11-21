using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        _prompts.Add("Did you set any goal for today?");
                _prompts.Add("What was the most memorable part of my day?");
                _prompts.Add("Are there any leftover tasks from yesterday that I need to complete today?");
                _prompts.Add("Who impressed or motivated me the most at work today?");
                _prompts.Add("Which gospel verse inspired me the most today?");
                _prompts.Add("What is my greatest challenge for the day?");
        Random guessNum = new Random();
        int num = guessNum.Next(0, 6);
        // System.Console.WriteLine(num);
        return _prompts[num];
    }
    
}