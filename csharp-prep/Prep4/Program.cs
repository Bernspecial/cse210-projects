using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        // Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        // Console.Write("Enter number: ");
        // string userInput = Console.ReadLine();
        // int enterNumber = int.Parse(userInput);
        int enterNumber = -1;
        int numberCount = 0;

        while (enterNumber != 0)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            enterNumber = int.Parse(userInput);
            numbers.Add(enterNumber);
        }
        foreach (int num in numbers)
        {
            numberCount += num;
        }
        float average = ((float)numberCount) / numbers.Count();
        int largest = numbers.Max();

        int sp = int.MaxValue;
        foreach (int numm in numbers)
        {
            if (numm > 0 && numm < sp)
            {
                sp = numm;
            }
        }

        Console.WriteLine($"The total is {numberCount}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {largest}");
        Console.WriteLine($"The smallest positive number is {sp}");
        numbers.RemoveAt(numbers.Count - 1);
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int sort in numbers)
        {
            Console.WriteLine(sort);
        }
    }
}