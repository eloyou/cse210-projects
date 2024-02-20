using System;

public class Event
{
    private string _eventType;
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event( string title, string description, string date, string time, Address address,string eventType = "")
    {
        _eventType = eventType;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetEventype()
    {
        return _eventType;
    }
    public void SetEventType(string eventType)
    {
        _eventType = eventType;
    }

    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public string GetDate()
    {
        return _date;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public string GetTime()
    {
        return _time;
    }
    public void SetTime(string time)
    {
        _time = time;
    }
    public string GetAddress()
    {
        return _address.GetDisplayAddress();
    }
    public void SetAddress(Address address)
    {
        _address = address;
    }
   
    public void GetStandardDetails()
    {
        Console.WriteLine($"{_title} - {_description} | {_date} / {_time} {GetAddress()}");
    }

    public void GetShortDescription()
    {
        Console.WriteLine($"{_eventType} Event: {_title} / Date: {_date}");
    }



}