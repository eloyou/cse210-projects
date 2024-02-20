using System;
using System.ComponentModel.DataAnnotations;

public abstract class Activity
{
    private string _date;
    private double _length;

    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }

    public string GetDate()
    {
        return _date;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public double GetLength()
    {
        return _length;
    }
    public void SetLength(double length)
    {
        _length = length;
    }


    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract void GetSummary();
}