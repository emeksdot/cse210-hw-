using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Word
{
    private string _text;
    // private const string  _lockedText = _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    public string GetWord()
    {
        return _text;
    }
    public void SetWord(string text)
    {
        _text = text;
    }

    // public void Hide()
    // {
    //     string hiddenWord = "";
    //     foreach (var item in _text)
    //     {
    //         hiddenWord += '_' ;
    //         _text = hiddenWord; 

    //     }
    // }
    

    public void Hide()
    {
        string str = new('_', _text.Length);
        _text = str;
    }

    public void Show()
    {
        System.Console.WriteLine(_text);
    }

    public bool IsHidden()
    {
        string str = new('_', _text.Length);
        if (_text != str)
        {
            return true;            
        }
        else
        {
            return false;
        }
    }

    public string GetDisplayText()
    {
        System.Console.WriteLine(_text);
        return _text;
    }
    
}