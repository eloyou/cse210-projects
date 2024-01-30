using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Clear();
        bool quit = false;


        while (!quit)
        {
            
            Console.WriteLine("\nThe Mindfullness App");
            Console.WriteLine("\nMenu options: \n");
            Console.WriteLine("  1. Start Breathing Activity ");
            Console.WriteLine("  2. Start Reflecting Activity ");
            Console.WriteLine("  3. Start Listing Activity ");
            Console.WriteLine("  4. Quit \n");
            Console.Write("Select a choice from the menu:  ");
            
            try
            {
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Clear();
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    
                    
                }
                else if (choice == 2)
                {
                    Console.Clear();
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                }
                else if (choice == 3)
                {
                    Console.Clear();
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Thank you!");
                    break;
                }

                else
                {
                    Console.Clear();
                }

            }
            
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.Clear();
            }
            
        }
        
    }
}