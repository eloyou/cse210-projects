using System;


public class Swimming : Activity
{
    private double _laps;
    
    public Swimming(string date, int length, double laps) : base(date,length)
    {
        base.SetDate(date);
        base.SetLength(length);
        _laps = laps;
       
    }


    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }
    public override double GetSpeed()
    {
        return GetDistance() / base.GetLength() * 60;
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
    public override void GetSummary()
    {
        Console.WriteLine($"{base.GetDate()} Swimming : No. of Laps: {_laps} - ({base.GetLength()} min)- Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per miles");
    }
}