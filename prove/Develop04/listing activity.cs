using System;


public class ListingActivity : Activity
{
    private int _count;

    private List<string> _listFromUser = new List<string>();
    private List<string> _prompts = new List<string>{
        "List things you are grateful for in your life right now.",
        "Compile a list of activities that bring you joy and relaxation.",
        "Create a list of short-term goals you want to achieve this week.",
        "List qualities you appreciate about yourself.",
        "Compile a list of books, movies, or songs that have inspired you recently.",
        "Write down things you can do to practice self-care today.",
        "List accomplishments you are proud of in your personal or professional life.",
        "Compile a list of positive affirmations to boost your confidence.",
        "Write down things you love about your favorite place or environment.",
        "List ways you can show kindness to yourself and others this week."
    };

    public ListingActivity(string name="Listing Activity",string description="this activity, take a moment for self-reflection and creativity.\nBelow, you'll find a series of prompts to inspire your lists.",int duration=5) : base(name,description,duration)
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

    public List<string> GetListFromUser()
    {
        return _listFromUser;
    }

    public int GetCount()
    {
        return _count;
    }
    public void SetCount(int count)
    {
        _count = count;
        
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

            Console.WriteLine("\nList as many responses you can to the following prompt: \n");
            Console.WriteLine($"---- {GetRandomPrompt()} ----");

            Console.WriteLine("\n");
            Console.Write($"You may begin in: ");
            for (int s = 5; s > 0;s--)
            {
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine("\n");

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(seconds);  

            int i = 0;

            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string response = Console.ReadLine();
                GetListFromUser().Add(response);
                
                
                i++;

                if (i >= seconds)
                {
                    i = 0;
                }
                
                SetCount(GetListFromUser().Count);
            }
            
            
            Console.WriteLine($"\nYou listed {GetCount()} items\n");
            
            base.DisplayEndingMessage(seconds);

        }
        catch (FormatException)
        {
            Console.Clear();
            Console.WriteLine("\nInvalid input. Please enter a valid number.\n");
            
        }
    }

}