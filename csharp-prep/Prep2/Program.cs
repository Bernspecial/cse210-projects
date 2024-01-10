using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("Your grade must be at least 70% to pass the class");
        Console.Write("What is your grade percentage? ");
        string userValue = Console.ReadLine();
        int grade = int.Parse(userValue);
        string letter = "";

        if (grade >= 97)
        {
            letter = "A+";
        }
        else if (grade >= 93 && (grade < 97))
        {
            letter = "A-";
        }
        else if ((grade >= 87) && grade < 93)
        {
            letter = "B+";
        }
        else if ((grade >= 83) && grade < 87)
        {
            letter = "B-";
        }
        else if ((grade >= 77) && grade < 83)
        {
            letter = "C+";
        }
        else if ((grade >= 73) && grade < 77)
        {
            letter = "C-";
        }
        else if ((grade >= 67) && grade < 73)
        {
            letter = "D+";
        }
        else if ((grade >= 63) && grade < 67)
        {
            letter = "D-";
        }
        else if ((grade >= 57) && grade < 63)
        {
            letter = "F+";
        }
        else if ((grade >= 53) && grade < 57)
        {
            letter = "F-";
        }
        Console.WriteLine($"Your grade is {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Oh! Sorry, please do btter next semster.");
        }
    }
}