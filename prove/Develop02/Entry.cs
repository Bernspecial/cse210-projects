public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry( string date, string prompt, string entryText)
    {
        _date = date;
        _promptText = prompt;
        _entryText = entryText;
        
    }
    public void DisplayEntry()
    {
        Console.WriteLine($"Date{_date}");
        Console.WriteLine($"{_promptText} \n{_entryText}");
        Console.WriteLine("");
    }
}