using System;
public class SimpleGoal : Goal
{
    private bool _isComplete;
    
    public SimpleGoal(string shortName, string description, int points, bool isComplete = false) : base(shortName,description,points)
    {
        base.SetShortName(shortName);
        base.SetDescription(description);
        base.SetPoints(points);
        _isComplete = isComplete;
    }


    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congratulations! You have earned {base.GetPoints()} ");
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailString()
    {
        if (_isComplete == true)
        {
            return $"[x] {base.GetShortName()} ({base.GetDescription()})";
        }
        else
        {
            return $"[ ] {base.GetShortName()} ({base.GetDescription()})";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{base.GetShortName()},{base.GetDescription()},{base.GetPoints()},{IsComplete()}";

    }


}