using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your Firstname? ");
        string firstname = Console.ReadLine();

        Console.WriteLine($"Hello {firstname}");
    }
}