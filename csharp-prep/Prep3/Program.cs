using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        //set a random number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);

        //default value is the magicNumber
        int response = 0;

        //while looping until the magic number is guessed
        while (response != magicNumber)
        {
            Console.Write("Whats the magic number? ");
            string guessNumber = Console.ReadLine();
            response = int.Parse(guessNumber);

            if (response > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (response < magicNumber)
            {
                Console.WriteLine("Higher");

            }
            else 
            {
                Console.WriteLine($"You guessed it! the magic number is {magicNumber}");
            }

        }

    }
}