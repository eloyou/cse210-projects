using System;
using System.Collections.Generic;
using System.IO; 

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            Console.WriteLine($"Date: {e._date} Time: {e._time} Prompt: {e._prompText}");
            Console.WriteLine(e._entryText);
            Console.WriteLine();
        }
    }

    public void SaveToFile()
    {
        string fileName = "myFile.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName,true))
        {
            foreach (Entry i in _entries)
            {
                outputFile.WriteLine($"Date: {i._date} Time: {i._time} Prompt: {i._prompText}");
                outputFile.WriteLine(i._entryText);
                outputFile.WriteLine();;
            }
        }
    }

    public void LoadFromFile()
    {
        string fileName = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

        
    }

    
}