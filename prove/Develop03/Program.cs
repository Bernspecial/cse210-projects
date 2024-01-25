using System;

class Program
{
    static void Main(string[] args)
    {
        // This create a random scripture to display for the user to exceed the code the requirement.
        List<Scripture> scriptures = new List<Scripture>()
        {
            new Scripture(new Reference("Alma", 40, 2), "Behold, I say unto you, that there is no resurrection—or, I would say, in other words, that this mortal does not put on immortality, this corruption does not put on incorruption—until after the coming of Christ."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("Matthew", 6, 33), "But seek ye first the kingdom of God, and his righteousness; and all these things shall be added unto you."),
            new Scripture(new Reference("Helema", 10, 4), "Blessed art thou, Nephi, for those things which thou hast done; for I have beheld how thou hast with unwearyingness declared the word, which I have given unto thee, unto this people. And thou hast not feared them, and hast not sought thine own life, but hast sought my will, and to keep my commandments."),
            new Scripture(new Reference("Romans", 8, 28), "And we know that all things work together for good to them that love God, to them who are the called according to his purpose.")
        };
        // Pick a random scripture from the list
            var random = new Random();
            var scripture = scriptures[random.Next(scriptures.Count)];
        
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        Console.WriteLine();
        Console.Write("Press enter to hide a few words or type quit to exit: ");
        string input = Console.ReadLine();

        while (input != "quit" && !scripture.IsCompletelyHiden())
        {
            scripture.HideRandonWord(1);
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.Write("Enter to hide a few words or type quit to exit: ");
            input = Console.ReadLine();

            if (scripture.IsCompletelyHiden())
            {
                Console.WriteLine("\nAll words are hidden. The program has ended.");
            }


        }
        
    }
}