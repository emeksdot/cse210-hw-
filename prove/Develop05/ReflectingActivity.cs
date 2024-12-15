using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
        _prompts = new List<string>();
        _questions = new List<string>();
    }

    //____________Prompts_____________
    public List<string> GetPrompts()
    {
        return _prompts;
    }

    public void SetPrompts(List<string> prompts)
    {
        _prompts = prompts;
    }

    //____________Questions_____________
    public List<string> GetQuestions()
    {
        return _questions;
    }

    public void SetQuestions(List<string> questions)
    {
        _questions = questions;
    }

    //____________Questions_____________
    public void Run() { }

    public string GetRandomPrompt()
    {
        _prompts.Add("---Think of a time when you stood up for someone else.---");
        _prompts.Add("---Think of a time when you did something really difficult.---");
        _prompts.Add("---Think of a time when you helped someone in need.---");
        _prompts.Add("---Think of a time when you did something truly selfless.---");

        Random guessNum = new Random();
        int num = guessNum.Next(0, 4);
        return _prompts[num];
    }

    public string GetRandomQuestion()
    {
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add(
            "What made this time different than other times when you were not as successful?"
        );
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add(
            "What could you learn from this experience that applies to other situations?"
        );
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        Random guessNum = new Random();
        int num = guessNum.Next(0, 5);
        return _prompts[num];
    }

    public void DisplayPrompt() { }

    public void DisplayQuestions() { }
}
