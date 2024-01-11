using System;

class Program
{
    static void Main(string[] args)
    {   
        //get user input for grade.
        Console.Write("What is your Grade? ");
        string userInput = Console.ReadLine();

        //convert string input into int variable.
        int grade = int.Parse(userInput);


        //else if statement
        string letterGrade;

        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else 
        {
            letterGrade = "F";
        }



        //assign "+" or "-" sign in grade
        string sign;

        int lastDigit = grade % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = " ";
        }
        
        //remove A+ and sign in F grade
        
        string finalGrade = letterGrade + sign;

        if (finalGrade == "F-" || finalGrade == "F+" || finalGrade == "F")
        {
            finalGrade = "F";
        }
        else if (finalGrade == "A+")
        {
            finalGrade = "A";
        }


        //determine if she/he passed.

        Console.WriteLine($"You've got {finalGrade}");
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, You Passeed this semester");
        }
        else
        {
            Console.WriteLine("I'm Sorry, You Failed this semester");
        }


        


        


    }
}