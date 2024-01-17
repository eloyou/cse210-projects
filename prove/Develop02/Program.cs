using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {

        List<string> prompts = new List<string>{
            "What's in your mind? " , "Do you have something that you are grateful of today? ",
            "What do you like to do? ", "Is there happening in your life that you want to share? ",
            "How are you today? "
        };

        Console.WriteLine("Welcome to My Journal Program=)");

        Journal journal = new Journal();
           
          
        int quit = 0;
        while (quit == 0)

        {
            Console.WriteLine();
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.WriteLine();
            Console.Write("What you would like to do? ");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                
                Entry entry = new Entry();
                PromptGenerator prompt = new PromptGenerator();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                string time = theCurrentTime.ToString("HH:mm:ss tt");
                
                prompt._prompts = prompts;
                entry._prompText = prompt.GetRandomPrompt();
                entry._date = dateText;
                entry._time = time; 
                entry.Display();
                entry._entryText = Console.ReadLine();
                journal.AddEntry(entry);
                
            }

            if (choice == 2)
            {
                journal.DisplayAll();
            }

            if (choice == 3)
            {
                journal.SaveToFile();
            }
            if (choice == 4)
            {
                journal.LoadFromFile();
            }
            if (choice == 5)
            {
                Console.WriteLine("Thank You for writing Journal today");
                quit = 1;
            }

            

        }
            
    }
}
