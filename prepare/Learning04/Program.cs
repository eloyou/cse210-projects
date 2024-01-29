using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Angelo", "Programming");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Paula Putong", "Accounting", "4.5", "6-9");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        Writing a3 = new Writing("Isaac Caringal", "Baby", "Our first born child");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}