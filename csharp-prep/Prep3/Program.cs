using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");
        // Console.Write("What is the magic number? ");
        // string userMagicNumber = Console.ReadLine();
        // int magicNumber = int.Parse(userMagicNumber);

        // Console.Write("What is your guess? ");
        // string userGuessNumber = Console.ReadLine();
        // int guessNumber = int.Parse(userGuessNumber);

        // if (magicNumber > guessNumber)
        // {
        //     Console.WriteLine("Higher");
        // }
        // else if (magicNumber < guessNumber)
        // {
        //     Console.WriteLine("Lower");
        // }
        // else if (magicNumber == guessNumber)
        // {
        //     Console.WriteLine("You Guessed it!");
        // }

        int guessCount = 0;

        // Console.Write("What is the magic number? ");
        // string userMagicNumber = Console.ReadLine();
        // int magicNumber = int.Parse(userMagicNumber);

        // Console.Write("What is your guess? ");
        // string userGuessNumber = Console.ReadLine();
        // int guessNumber = int.Parse(userGuessNumber);

        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1, 1000000);

        int guessNumber = -1;


        while (magicNumber != guessNumber)
        {
            Console.Write("What is your guess? ");
            string userGuessNumber = Console.ReadLine();
            guessNumber = int.Parse(userGuessNumber);
            guessCount++;
            
            if (magicNumber > guessNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guessNumber)
            {
                Console.WriteLine("Lower");
            }
            
            
        }
        Console.WriteLine($"You Guessed it! you guessed it {guessCount} times");

    }
}