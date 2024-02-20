using System;

public class Lectures : Event
{

    private string _speaker;
    private int _capacity;
    public Lectures(string title, string description, string date, string time, Address address, string speaker, int capacity,string eventType = "Lecture") : base(title,description,date,time,address,eventType)
    {
        base.SetTitle(title);
        base.SetDescription(description);
        base.SetDate(date);
        base.SetTime(time);
        base.SetAddress(address);
        base.SetEventType(eventType);
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetSpeaker()
    {
        return _speaker;
    }
    public void SetSpeaker(string speaker)
    {
        _speaker = speaker;
    }
    public int GetCapacity()
    {
        return _capacity;
    }
    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
    }

    public void GetFullDetails()
    {
        Console.WriteLine($"-> Speaker: {_speaker} / Capacity: {_capacity}");
    }
    

    


}