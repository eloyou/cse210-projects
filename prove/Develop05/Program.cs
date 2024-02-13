using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        GoalManager goalManager = new GoalManager();
        bool quit = false;
        
        Console.WriteLine("\nWelcome to Eternal Quest\n");
        

        while (quit is not true)
        {
            goalManager.Start();
            
            
            string menu = Console.ReadLine();
            
            if (menu == "1")
            {
                Console.WriteLine("\nSelect Goals:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.Write("What type of Goal Would You Like to Create? \nEnter number, type m to back to menu: --> ");
                string goalMenu = Console.ReadLine();

                if (goalMenu == "1")
                {
                    Console.Clear();
                    Console.Write("\nWhat is the name of your Goal? ");
                    string shortName = Console.ReadLine();
                    Console.Write("What is the short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this Goal? ");
                    int points = int.Parse(Console.ReadLine());
                    SimpleGoal simpleGoal = new SimpleGoal(shortName,description,points);
                    goalManager.SetGoal(simpleGoal);
                    Console.Clear();

                }
                else if (goalMenu == "2")
                {
                    Console.Clear();
                    Console.Write("\nWhat is the name of your Eternal Goal? ");
                    string shortName = Console.ReadLine();
                    Console.Write("What is the short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this Eternal Goal? ");
                    int points = int.Parse(Console.ReadLine());
                    EternalGoal eternalGoal = new EternalGoal(shortName,description,points);
                    goalManager.SetGoal(eternalGoal);
                    Console.Clear();
                }
                else if (goalMenu == "3")
                {
                    Console.Clear();
                    Console.Write("\nWhat is the name of your Checklist Goal? ");
                    string shortName = Console.ReadLine();
                    Console.Write("What is the short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this Goal? ");
                    int points = int.Parse(Console.ReadLine());
                    Console.Write("How many times you would this Goal? ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("How much bonus, you want to get after you complete this Goal ? ");
                    int bonus = int.Parse(Console.ReadLine());
                    ChecklistGoal checklistGoal = new ChecklistGoal(shortName,description,points,target,bonus);
                    goalManager.SetGoal(checklistGoal);
                    Console.Clear();
                }
            }
            else if (menu == "2")
            {   
                Console.Clear();
                goalManager.ListGoals();
            }
            else if (menu == "3")
            {   
                Console.Clear();
                Console.Write("What filename?  ");
                string filename = Console.ReadLine();
                goalManager.SaveGoals(filename);
            }
            else if (menu == "4")
            {   
                Console.Clear();
                Console.Write("What filename?  ");
                string filename = Console.ReadLine();
                goalManager.LoadGoals(filename);
            }

            else if (menu == "5")
            {
                goalManager.RecordEvent();
                
                
            }
            else if (menu == "6")
            {
                break;
                
                
            }

                
         
        }
        
    }
}