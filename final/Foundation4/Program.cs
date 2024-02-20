using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running("Feb 21, 2024", 30, 3);
        Cycling cycling = new Cycling("Feb 21, 2024", 30, 4);
        Swimming swimming = new Swimming("Feb 21, 2024", 30, 5);
        

        running.GetSummary();
        cycling.GetSummary();
        swimming.GetSummary();
    
   
    }
}