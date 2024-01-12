using System;
using System.Collections.Generic;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        int numInput = 1;
        int sumNumber = 0;
        double average = 0;
        int largestNum = 0;
        
        while (numInput != 0)
        {
            
            Console.Write("Enter a number? ");
            string userInput = Console.ReadLine();
            numInput = int.Parse(userInput);

            if (numInput != 0)
            {
                numberList.Add(numInput);
            }
            else
            {
                numInput = 0;
            }
            
        }

        foreach (int num in numberList)
        {
            sumNumber += num;
            average = Convert.ToDouble(sumNumber) / numberList.Count;

            if (num > largestNum)
            {
                largestNum = num;
            }
            
        }

        
        Console.WriteLine($"The sum is {sumNumber}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The Largest Number is {largestNum}");

    }
}