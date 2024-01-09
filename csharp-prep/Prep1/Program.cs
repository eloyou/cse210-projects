using System;

class Program
{
    static void Main(string[] args)
    {
        //ask the user for thier name
        Console.Write("What is your Firstname? ");
        string firstname = Console.ReadLine();

        Console.Write("What is your Lastname? ");
        string lastname = Console.ReadLine();

        Console.WriteLine($"Hello, You're  {firstname} {lastname} thank you for coming!");
    }
}