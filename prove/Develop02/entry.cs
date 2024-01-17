using System;
using System.Collections.Generic;

public class Entry
{
    public string _date;
    public string _prompText;
    public string _entryText;

    public string _time;
    
    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"{_prompText} ");
    }
}

