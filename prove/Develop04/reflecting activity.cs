using System;
using System.Reflection;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>{
        "Recall a moment of deep joy or happiness in your life.",
        "Consider a challenge you are currently facing.",
        "Reflect on a recent interaction with someone. ",
        "Think of a mistake you've made. ",
        "Recall a time when you felt overwhelmed or stressed. ",
        "Consider a goal or aspiration you have. ",
        "Reflect on a favorite activity or hobby. ",
        "Think about a moment of stillness or tranquility you've experienced.",
        "Recall a time when you felt proud of an accomplishment. ",
        "Consider a relationship in your life.",
    };

    private List<string> _questions = new List<string>{
        "What specific event or circumstance makes you feel grateful?",
        "How does expressing gratitude impact your overall well-being?",
        "What strategies do you typically use to stay calm in challenging situations?",
        "How might a calm and collected approach positively influence the outcome?",
        "What emotions did the recent interaction evoke in you?",
        "How can you enhance positive feelings in future interactions?",
        "What lessons or personal growth have you gained from that experience?",
        "How can you apply those lessons to future situations and foster a mindset of continuous improvement?",
        "How did you manage your emotions?",
        "What additional strategies or mindfulness techniques could you explore to manage stress in the future?"
    };

    public ReflectingActivity(string name="Reflecting Activity", string description="This activity encourages self-reflection, guiding you through prompts to foster mindfulness and deepen your awareness.\nEmbrace each question as a moment for personal growth and gratitude",int duration=5) : base(name,description,duration)
    {
        base.SetName(name);
        base.SetDescription(description);
        base.SetDuration(duration);
    }

    public string GetRandomPrompt()
    {
        string selectedPrompt = "";

        Random random = new Random();

        // Shuffle the list using Fisher-Yates algorithm
        _prompts = _prompts.OrderBy(x => random.Next()).ToList();

        // Iterate through the shuffled list
        foreach (string p in _prompts)
        {
            // Print the current prompt
            selectedPrompt = p;
        }

        return selectedPrompt;
    }
    public string GetRandomQuestion()
    {
        string selectedQuestion = "";

        Random random = new Random();

        // Shuffle the list using Fisher-Yates algorithm
        _questions = _questions.OrderBy(x => random.Next()).ToList();

        // Iterate through the shuffled list
        foreach (string q in _questions)
        {
            // Print the current Question
            selectedQuestion = q;
        }

        return selectedQuestion;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"----- {GetRandomPrompt()} -----\n");
    }
    public void DisplayQuestion()
    {
        Console.Write($"> {GetRandomQuestion()} ");
        base.ShowSpinner(10);
        Console.WriteLine("\n");
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
  

            Console.WriteLine("\nConsider the Following Prompt: \n");
            DisplayPrompt();

            Console.Write("When you have something in mind, press enter to continue. ");
            Console.ReadLine();

            Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience");
            Console.Write("You may begin in...");
            for (int s = 5; s > 0;s--)
            {
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.Clear();
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(seconds);
            int i = 0;

            while (DateTime.Now < endTime)
            {
                DisplayQuestion();

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