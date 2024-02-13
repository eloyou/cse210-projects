using System;

public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName,description,points)
    {
        base.SetShortName(shortName);
        base.SetDescription(description);
        base.SetPoints(points);
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {base.GetPoints()} ");
        
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailString()
    {
        
        return $"{base.GetShortName()} ({base.GetDescription()})";
         
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{base.GetShortName()},{base.GetDescription()},{base.GetPoints()}";

    }
}