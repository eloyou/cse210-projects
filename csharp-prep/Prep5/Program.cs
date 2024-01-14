using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNum = SquareNumber(userNumber);
        DisplayResult(userName,squaredNum);
        
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }
        static int SquareNumber(int favNumber)
        {
            int squared = favNumber * favNumber;
            return squared;
        }
        static void DisplayResult(string userName, int userNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {userNumber}");
        }
        
    }

    
}