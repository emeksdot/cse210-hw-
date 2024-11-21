using System;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {
         _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach(Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        string fileName = "journal.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName)){
            outputFile.WriteLine();
        }
    }
    
}