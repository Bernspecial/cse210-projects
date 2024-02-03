using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop04 World!");   

        while (true)
        {
            Console.WriteLine("Menu Option:");
            Console.WriteLine(" 1. Start Breathing Activity.");
            Console.WriteLine(" 2. Start Reflecting Activity.");
            Console.WriteLine(" 3. Start Listing Activity.");
            Console.WriteLine(" 4. Meditation Activities.");
            Console.WriteLine(" 5. Quit.");
            Console.Write("Select an option from the list above: ");
            String userInput  = Console.ReadLine();
            int userInt = int.Parse(userInput);
            Console.Clear();

            if (userInt == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This is an activity to relax your mind.");
                breathingActivity.Run();
                // log.SaveActivity(breathingActivity);

            }

            if (userInt == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.");
                reflectingActivity.Run();
                // log.SaveActivity(reflectingActivity);

            }

            if (userInt == 3)
            {
                ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listingActivity.Run();
                // log.SaveActivity(listingActivity);


            }

            if (userInt == 4)
            {
                MeditationActivity meditationActivity = new MeditationActivity("Meditation Activity", "This activity will help you to think of a word to meditate and say the word out loud after");
                meditationActivity.Run();
            }

            if (userInt == 5)
            {
                break;
            }
        }
        

    }
}