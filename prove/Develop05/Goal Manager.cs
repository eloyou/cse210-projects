using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public List<Goal> GetGoal()
    {
        return _goals;
    }
    public void SetGoal(Goal goals)
    {
        _goals.Add(goals);
    }
    public int GetScore()
    {
        return _score;
    }
    public void SetScore(int score)
    {
        _score += score;
    }

    public void Start()
    {
        Console.Write($"\nYou Now Have ");
        Console.WriteLine($"Score: {GetScore()}\n");
        Console.WriteLine("Menu Options:\n");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("\nSelect the Choice from the menu: ");

    }
    
    public void ListGoals()
    {
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index++}. {goal.GetDetailString()}");

        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.Clear();
        }
        else
        {
            int index = 1;
            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"{index++}. {goal.GetShortName()}");
                
            }

            Console.Write("\nSelect Goal to Record: ");
            int goalIndex = int.Parse(Console.ReadLine());

            if (_goals[goalIndex - 1].IsComplete() == true)
            {
                Console.Clear();
                Console.WriteLine("\nAlready Done!");
            }
            else
            {
                Console.Clear();
                _goals[goalIndex - 1].RecordEvent();
                SetScore(_goals[goalIndex - 1].GetPoints());

            }

        }   

    }
    public void SaveGoals(string file)
    {
        using (StreamWriter w = new StreamWriter($"{file}.txt"))
        {
            w.WriteLine($"Score:{GetScore()}");

            foreach (Goal goal in _goals)
            { 
                w.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string file)
    {
        try
        {
            string[] inputs = File.ReadAllLines($"{file}.txt");
        
            foreach (string input in inputs)
            {
                if (input.Contains("Score:"))
                {
                    string[] scorePart = input.Split("Score:");
                    int score = int.Parse(scorePart[1]);
                    SetScore(score);

                }
                else if (input.Contains("SimpleGoal"))
                {
                    string[] goal = input.Split("SimpleGoal:");
                    string[] goalsPart = goal[1].Split(',');

                    string shortName = goalsPart[0];
                    string description = goalsPart[1];
                    int points = int.Parse(goalsPart[2]);
                    bool isComplete = bool.Parse(goalsPart[3]);

                    SimpleGoal simpleGoal = new SimpleGoal(shortName,description,points,isComplete);
                    _goals.Add(simpleGoal); 
                }

                else if (input.Contains("EternalGoal"))
                {
                    string[] goal = input.Split("EternalGoal:");
                    string[] goalsPart = goal[1].Split(',');

                    string shortName = goalsPart[0];
                    string description = goalsPart[1];
                    int points = int.Parse(goalsPart[2]);

                    EternalGoal eternalGoal = new EternalGoal(shortName,description,points);
                    _goals.Add(eternalGoal); 
                }
                else if (input.Contains("ChecklistGoal"))
                {
                    string[] goal = input.Split("ChecklistGoal:");
                    string[] goalsPart = goal[1].Split(',');

                    string shortName = goalsPart[0];
                    string description = goalsPart[1];
                    int points = int.Parse(goalsPart[2]);
                    int bonus = int.Parse(goalsPart[3]);
                    int target = int.Parse(goalsPart[4]);
                    int amountCompleted = int.Parse(goalsPart[5]);
                    bool isComplete = bool.Parse(goalsPart[6]);

                    ChecklistGoal checklistGoal = new ChecklistGoal(shortName,description,points,target,bonus,isComplete);
                    _goals.Add(checklistGoal); 
                    checklistGoal.SetAmountCompleted(amountCompleted);
                }
                
                
            }
        }
        catch (Exception)
        {
            Start();

        }
        
        
    }


       
}