using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");

        Assignment assignment = new Assignment("Michael Bernard", "Web & Computer Programming");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Michael Bernard", "Web & Computer Programming","7.3", "7-5");
        Console.WriteLine(mathAssignment.GetHomeWorkList());

        WritingAssignment writingAssignment = new WritingAssignment("Michael Bernard", "Web & computer programming", "Introduction to programming");
        Console.WriteLine(writingAssignment.GetWritingInformation());



    }
}