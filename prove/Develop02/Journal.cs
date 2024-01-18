public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public  PromptGenerator promptGenerator = new PromptGenerator();
    

    public void AddEntry()
    {
        DateTime updateDateTime = DateTime.Now;
        string currentDate = updateDateTime.ToShortDateString();
        Console.WriteLine($"Date: {currentDate}");
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        string textEntry = Console.ReadLine();
        Entry newEntry = new (currentDate, prompt, textEntry);
        _entries.Add(newEntry);
    }

    
    public void DisplayAll()
    {
        foreach (Entry user in _entries)
        {
            user.DisplayEntry();
        }
    }

    // i added this to make useer clear there entry incase they feel trying again
    public void ClearEntry()
    {
        _entries.Clear();
    }
    public void SaveToFile()
    {
        Console.Write("What is the file name?");
        string userFileName = Console.ReadLine();
        using (StreamWriter userInput = new StreamWriter (userFileName))
        {
            foreach (Entry userchoice in _entries)
            {
                userInput.WriteLine($"{userchoice._date},{userchoice._promptText},{userchoice._entryText}");
            }
            Console.WriteLine($"Your file as been saved to {userFileName}");
        }
    }

    // I added thid to make easier for the user to delete any saved file anytime they feel like.
    public void DeleteSavedFile()
    {
        Console.Write("What is the file name? ");
        string savedFileName = Console.ReadLine();
        if (System.IO.File.Exists(savedFileName))
        {
            System.IO.File.Delete(savedFileName);
            Console.WriteLine($"{savedFileName} has been deteted");
        }
        else
        {
            Console.WriteLine("The file does not exist.");
        }
    }
    // I added IF sattement so that if the user enter file not saved, they can get a propmt that the file doesn't exist
    public void LoadFromFile()
    {
        Console.Write("What's the filename? ");
        string fileName = Console.ReadLine();
        Console.WriteLine("");
        if (System.IO.File.Exists(fileName))
        {
            string[] allLines = System.IO.File.ReadAllLines(fileName);
            foreach (string line in allLines)
            {
                string[] parts = line.Split(",");

                string firstIndex = parts[0];
                string secondIndex = parts[1];
                string thirdIndex = parts[2];
                Console.WriteLine($"{firstIndex}, {secondIndex}, {thirdIndex}");
            }
        }
        else
        {
            Console.WriteLine("The file does not exist.");
        }
        Console.WriteLine("");

    }
    
}