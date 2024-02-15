// Define a public class "Income" that inherits from the "Transaction" class
public class Income : Transaction
{
    // Constructor for the "Income" class that accepts three parameters:
    // "date" of type DateTime, "description" of type string, and "amount" of type decimal
    public Income(DateTime date, string description, decimal amount) : base(date, description, amount) { }

    // Override the "Display" method from the "Transaction" class
    public override void Display()
    {
        // Write a formatted string to the console that includes the income's date, description, and amount
        Console.WriteLine($"Income: {GetDate().ToShortDateString()}  Income  {GetDescription()}  ${GetAmount()}");
    }
}