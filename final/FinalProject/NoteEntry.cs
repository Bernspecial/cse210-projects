// Define a public class "NoteEntry" that inherits from the "Transaction" class
public class NoteEntry : Transaction
{
    // Declare private string fields "_promptText" and "_entryText" to store the prompt and entry text respectively
    private string _promptText;
    private string _entryText;

    // Constructor for the "NoteEntry" class that accepts five parameters:
    // "date" of type DateTime, "description" of type string, "amount" of type decimal, "prompt" of type string, and "entryText" of type string
    public NoteEntry(DateTime date, string description, decimal amount, string prompt, string entryText) : base(date, description, amount)
    {
        // Assign the "prompt" parameter to the "_promptText" field
        _promptText = prompt;

        // Assign the "entryText" parameter to the "_entryText" field
        _entryText = entryText;
    }

    // Define a method "GetPrompt" that returns the prompt text as a string
    public string GetPrompt()
    {
        // Return the value of the "_promptText" field
        return _promptText;
    }

    // Define a method "GetEntry" that returns the entry text as a string
    public string GetEntry()
    {
        // Return the value of the "_entryText" field
        return _entryText;
    }

    // Override the "DisplayEntry" method from the "Transaction" class
    public override void DisplayEntry()
    {
        // Write a formatted string to the console that includes the prompt and entry text
        Console.WriteLine($"{_promptText} \n{_entryText}");

        // Write an empty line to the console
        Console.WriteLine("");
    }

    // Override the "Display" method from the "Transaction" class
    public override void Display()
    {
        // Write a formatted string to the console that includes the date, description, and amount of the note entry
        Console.WriteLine($"NoteSave {GetDate().ToShortDateString()} {GetDescription()}  ${GetAmount()}");
    }
}