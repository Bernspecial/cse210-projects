// Define a public class "Expense" that inherits from the "Transaction" class
public class Expense : Transaction
{
    // Declare a private string field "_purpose" to store the purpose of the expense
    private string _purpose;

    // Constructor for the "Expense" class that accepts four parameters:
    // "date" of type DateTime, "description" of type string, "amount" of type decimal, and "purpose" of type string
    public Expense(DateTime date, string description, decimal amount, string purpose) : base(date, description, amount)
    {
        // Assign the "purpose" parameter to the "_purpose" field
        _purpose = purpose;
    }

    // Define a method "GetPurpose" that returns the purpose of the expense as a string
    public string GetPurpose()
    {
        // Return the value of the "_purpose" field
        return _purpose;
    }

    // Override the "Display" method from the "Transaction" class
    public override void Display()
    {
        // Write a formatted string to the console that includes the expense's date, description, amount, and purpose
        Console.WriteLine($"Expense {GetDate().ToShortDateString()}  {GetDescription()} {GetAmount()} {GetPurpose()}");
    }
}