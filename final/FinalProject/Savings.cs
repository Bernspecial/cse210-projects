// Define a public class "Savings" that inherits from the "Transaction" class
public class Savings : Transaction
{
    // Constructor for the "Savings" class that accepts three parameters:
    // "date" of type DateTime, "description" of type string, and "amount" of type decimal
    public Savings(DateTime date, string description, decimal amount) : base(date, description, amount) { }

    // Override the "Display" method from the "Transaction" class
    public override void Display()
    {
        // Write a formatted string to the console that includes the savings' date, description, and amount
        Console.WriteLine($"Saving: {GetDate().ToShortDateString()} {GetDescription()}  ${GetAmount()}");
    }
}