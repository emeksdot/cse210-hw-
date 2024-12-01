using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    
    public Scripture(Reference reference, string text) 
    {
        _reference = reference;
        List<Word> temp = new List<Word>();
        string[] stringArray = text.Split(' ');
        foreach (string item in stringArray)
        {
            Word word = new Word(item);
            temp.Add(word);
        }
        _words = temp;
    }
         

    

    public void HideRandomWords(int numberToHide)
    {
        int i = 0;
        List<int> intArray = new List<int>();
        while (i < numberToHide)
        {
            Random randomNumber = new Random();
            int num = randomNumber.Next(0, _words.Count);
            while (intArray.Count < numberToHide)
            {
                num = randomNumber.Next(0, _words.Count);
                if (!intArray.Contains(num))
                {
                    intArray.Add(num);                    
                }
                else
                {
                    continue;
                }
                
            }
            
            // System.Console.WriteLine(intArray.Count);
            foreach (var number in intArray)
            {
                string str = new('_', _words[number].GetWord().Length);
                _words[number].SetWord(str);
                
            }
            
            i++;
            
        }
    }

    public string GetDisplayText()
    {
        string temp2 = "";
        foreach (var item in _words)
        {
            temp2 += item.GetWord() + " ";
        }
        return temp2;
    }

    public bool IsCompleteleyHidden()
    {
        return false;
    }
}