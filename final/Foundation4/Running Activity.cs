using System;


public class Running : Activity
{
    private double _distance;
    public Running(string date, int length, double distance) : base(date,length)
    {
        base.SetDate(date);
        base.SetLength(length);
        _distance = distance;
       
    }


    public void SetDistance(double distance)
    {
        _distance = distance;
    }
    

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance / base.GetLength()) * 60;
    }
    public override double GetPace()
    {
        return base.GetLength() / _distance ;
    }
    public override void GetSummary()
    {
        Console.WriteLine($"{base.GetDate()} Running ({base.GetLength()} min)- Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per miles");
    }
}