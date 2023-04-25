using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

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

        Console.WriteLine($"Your grade is: {letterGrade}");

        if (grade >= 70)
        {
            Console.WriteLine("Congradulations! That's a passing grade!");
        }

        else
        {
            Console.WriteLine("It looks like you've got some work to do. You've got this!");
        }
    }
}