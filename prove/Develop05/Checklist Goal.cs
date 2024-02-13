using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    private bool _isComplete;

    public ChecklistGoal(string shortName,string description,int points,int target, int bonus,bool isComplete=false) : base(shortName,description,points)
    {
        base.SetShortName(shortName);
        base.SetDescription(description);
        base.SetPoints(points);
        _target = target;
        _bonus = bonus;
        _isComplete = isComplete;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public void SetAmountCompleted(int amount)
    {
        _amountCompleted += amount;
    }

    public override void RecordEvent()
    {

  
        SetAmountCompleted(1);
        
        Console.WriteLine($"Congratulations! You have earned {base.GetPoints()} ");

        if (_amountCompleted == _target)
        {
            _isComplete = true;
            base.SetPoints(_bonus);
        }
        
        
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailString()
    {
        if (IsComplete() == true)
        {
            return $"[x] {base.GetShortName()} ({base.GetDescription()} {GetAmountCompleted()}/{_target})";
        }
        else
        {
            return $"[ ] {base.GetShortName()} ({base.GetDescription()} {GetAmountCompleted()}/{_target})";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{base.GetShortName()},{base.GetDescription()},{base.GetPoints()},{_bonus},{_target},{GetAmountCompleted()},{IsComplete()}";
    }
}