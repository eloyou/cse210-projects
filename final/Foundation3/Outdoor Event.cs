using System;

public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string description, string date, string time, Address address, string weather,string eventType = "Outdoor") : base(title,description,date,time,address,eventType)
    {
        base.SetTitle(title);
        base.SetDescription(description);
        base.SetDate(date);
        base.SetTime(time);
        base.SetAddress(address);
        base.SetEventType(eventType);
        _weather = weather;
    }

    public string GetWeather()
    {
        return _weather;
    }
    public void SetWeather(string weather)
    {
        _weather = weather;
    }
    
    public void GetFullDetails()
    {
        Console.WriteLine($"->  The Weather today is {_weather}");
    }
  

    


}