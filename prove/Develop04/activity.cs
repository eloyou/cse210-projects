using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.Write("How Long, in seconds, would you like for your session? ");
    }

    public void DisplayEndingMessage(int seconds)
    {
        Console.WriteLine("\n\nWell Done!!");
        ShowSpinner(GetDuration());
        Console.WriteLine($"\nYou have completed another {seconds} seconds of the {GetName()}");
        ShowSpinner(GetDuration());
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>
        {
            "|","/","-","\\","|","/","-","\\"

        };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);  

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);  

        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(".");
            Thread.Sleep(1000);

            i++;
        }
    }
}