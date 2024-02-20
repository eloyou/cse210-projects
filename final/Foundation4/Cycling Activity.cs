using System;


public class Cycling : Activity
{
    private double _distance;
    public Cycling(string date, int length, double distance) : base(date,length)
    {
        base.SetDate(date);
        base.SetLength(length);
        _distance = distance;
       
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return _distance / base.GetLength() * 60;
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
    public override void GetSummary()
    {
        Console.WriteLine($"{base.GetDate()} Cycling ({base.GetLength()} min)- Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per miles");
    }
}