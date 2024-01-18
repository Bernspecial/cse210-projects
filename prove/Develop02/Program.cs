using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");
        Journal journal = new Journal();


        Console.WriteLine("Journal.");
        Console.WriteLine("");

        while (true)
        {
            Console.WriteLine("Choose from the following. (1-5):");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Clear Entry");
            Console.WriteLine("4.Save File");
            Console.WriteLine("5.Load File");
            Console.WriteLine("6.Delete File");
            Console.WriteLine("7.Quit");
            Console.WriteLine("");
            Console.Write("Enter: ");
            string choice = Console.ReadLine();        
            Console.WriteLine("");

            if (choice == "1")
            {
                journal.AddEntry();
            }
            if (choice == "2")
            {
                journal.DisplayAll();
            }
            if (choice == "3")
            {
                journal.ClearEntry();
            }
            if (choice == "4")
            {
                journal.SaveToFile();
            }
            if (choice == "5")
            {
                journal.LoadFromFile();
            }
            if (choice == "6")
            {
                journal.DeleteSavedFile();
            }
            if (choice == "7")
            {
                Console.WriteLine("Thank you for using the journal.");
            }
        }


    }
}