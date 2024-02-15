public abstract class Transaction
{
    // Private fields for date, description, and amount of the transaction
    private DateTime _date;
    private string _description;
    private decimal _amount;

    // Constructor to initialize the transaction with date, description, and amount
    public Transaction(DateTime date, string description, decimal amount)
    {
        _date = date;
        _description = description;
        _amount = amount;
    }

    // Method to get the date of the transaction
    public DateTime GetDate()
    {
        return _date;
    }

    // Method to get the description of the transaction
    public string GetDescription()
    {
        return _description;
    }

    // Method to get the amount of the transaction
    public decimal GetAmount()
    {
        return _amount;
    }

    // Virtual method to display the transaction entry
    // This method is virtual so it can be overridden in derived classes
    public virtual void DisplayEntry()
    {
        // Display the date, description, and amount of the transaction
        Console.WriteLine($"Date: {GetDate()}, Description: {GetDescription()}, Amount: {GetAmount()}");
    }

    // Abstract method to display the transaction
    // This method is abstract because each derived class should have its own implementation
    public abstract void Display();
}