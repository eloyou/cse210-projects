using System;

public class Reception : Event
{
    private string _email;

    public Reception(string title, string description, string date, string time, Address address, string email,string eventType = "Reception") : base(title,description,date,time,address,eventType)
    {
        base.SetTitle(title);
        base.SetDescription(description);
        base.SetDate(date);
        base.SetTime(time);
        base.SetAddress(address);
        base.SetEventType(eventType);
        _email = email;
    }

    public string GetEmail()
    {
        return _email;
    }
    public void SetEmail(string email)
    {
        _email = email;
    }
    
    public void GetFullDetails()
    {
        Console.WriteLine($"RSVP -> Email: {_email}");
    }


}