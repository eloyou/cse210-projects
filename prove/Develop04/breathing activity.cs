using System;

public class BreathingActivity : Activity
{

    public BreathingActivity( string name="Breathing Activity", string description="This Activity will help you relax by walking through breathing in and out slowly. \nClear Your Mind and Fucos on your Breathing",int duration=5) : base(name, description,duration)
    {
        base.SetName(name);
        base.SetDescription(description);
        base.SetDuration(duration);
    }

    public void Run()
    {

        
        base.DisplayStartingMessage();

        try
        {
            int seconds = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Get Ready...");
            base.ShowSpinner(base.GetDuration());

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(seconds);  

            Console.WriteLine("\n");
            Console.Write($"Breathing In....");
            for (int s = 2; s > 0;s--)
            {
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                
            }
            Console.WriteLine();
            Console.Write($"Now Breathing Out....");
            for (int s = 3; s > 0;s--)
            {
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            int i = 0;

            while (DateTime.Now < endTime)
            {
                Console.WriteLine("\n");
                Console.Write($"Breathing In....");
                for (int s = 4; s > 0;s--)
                {
                    Console.Write(s);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }

                Console.WriteLine();
                Console.Write($"Now Breathing Out....");
                for (int s = 6; s > 0;s--)
                {
                    Console.Write(s);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }

                i++;

                if (i >= seconds)
                {
                    i = 0;
                }

            }

            base.DisplayEndingMessage(seconds);
        }
        catch (FormatException)
        {
            Console.Clear();
            Console.WriteLine("\nInvalid input. Please enter a valid number.\n");
            
        }

        
    }
}