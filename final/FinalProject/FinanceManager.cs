
// The FinanceManager class contains a list of Transaction objects, as well as a PromptText object for generating random prompt texts. 
public class FinanceManager
{
    private List<Transaction> _transactions;
    private PromptText _promptText;

    public FinanceManager()
    {
        _transactions = new List<Transaction>();
        _promptText = new PromptText();
    }

// The class has a StartMenu method that displays a menu to the user and allows them to choose between tracking their finances, writing a note, 
// saving a note, loading a note, displaying transactions, and exiting the program.
    public void StartMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("One interesting problem that people have is managing their personal finances. ");
            Console.WriteLine("They often struggle to keep track of their income, expenses, and savings.");
            Console.WriteLine("This program will help you in keeping track of your  INCOME,EXPENSE and your SAVINGS.");
            Console.WriteLine("This program will also help you make notes about your finance with some provided prompt text.");
            Console.WriteLine();
            // Display menu options

            Console.WriteLine("1. Track Your Expenses:");
            Console.WriteLine("2. Write A Note:");
            Console.WriteLine("3. Save Note:");
            Console.WriteLine("4. Load Note:");
            Console.WriteLine("5. Display Transactions:");
            Console.WriteLine("6. Exit:");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");

            // Get user input
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    TrackFinance();
                    break;
                case 2:
                    AddEntry();
                    break;
                case 3:
                    SaveToFile();
                    break;
                case 4:
                    LoadFromFile();
                    break;
                case 5:
                    DisplayTransactions();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }



// The TrackFinance method prompts the user to enter the description and amount of a new transaction, as well as the type of transaction 
// (income, expense, or savings).
    public void TrackFinance()
    {
        DateTime updateDateTime = DateTime.Now;
        Console.Write("What is the description of the transaction? ");
        string description = Console.ReadLine();
        Console.Write("How much is the amount? ");
        decimal amount = decimal.Parse(Console.ReadLine());

        Console.WriteLine("\nWhat is the type of transaction?");
        Console.WriteLine("1. Income");
        Console.WriteLine("2. Expense");
        Console.WriteLine("3. Savings");

        Console.Write("Select a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());

        Transaction transaction;

        switch (choice)
        {
            case 1:
                transaction = new Income(updateDateTime, description, amount);
                break;
            case 2:
                Console.Write("What is the purpose of the expense? ");
                string purpose = Console.ReadLine();
                transaction = new Expense(updateDateTime, description, amount, purpose);
                break;
            case 3:
                transaction = new Savings(updateDateTime, description, amount);
                break;
            default:
                Console.WriteLine("Invalid choice. Selecting Income as default.");
                transaction = new Income(updateDateTime, description, amount);
                break;
        }

        _transactions.Add(transaction);
    }

// The AddEntry method prompts the user to enter a note with a guide question. Both methods add the new transaction or note to the 
// _transactions list.
    public void AddEntry()
    {   Console.WriteLine("This note is to help you react to some certain questions just to lock your transaction.");
        string prompt = _promptText.GetRandomPrompt();
        Console.WriteLine($"A Prompt Text To Guide You:");
        Console.WriteLine(prompt);
        Console.WriteLine();
        Console.WriteLine("What would you like to note down?");
        string entryText = Console.ReadLine();
        NoteEntry noteEntry = new NoteEntry(DateTime.Now, prompt, 9, prompt, entryText);
        _transactions.Add(noteEntry);
    }

    // public void AddTransaction(Transaction transaction)
    // {
    //     _transactions.Add(transaction);
    // }


// The DisplayTransactions method displays all the transactions in the list in a formatted way.
    public void DisplayTransactions()
    {
        Console.WriteLine("Your Transactions:");
        Console.WriteLine("-----------------");

        foreach (Transaction transaction in _transactions)
        {
            Console.WriteLine($"{transaction.GetDate()}: {transaction.GetDescription()} - {transaction.GetAmount()}");

            if (transaction is Expense)
            {
                Expense expense = (Expense)transaction;
                Console.WriteLine($"Purpose: {expense.GetPurpose()}");
            }

            if (transaction is NoteEntry)
            {
                NoteEntry noteEntry = (NoteEntry)transaction;
                Console.WriteLine($"Note: {noteEntry.GetEntry()}");
            }

            Console.WriteLine();
        }
    }


// The SaveToFile method prompts the user to enter a filename and saves the list of transactions to a file in a text format.
    public void SaveToFile()
{
    Console.Write("Enter the filename to save the transactions: ");
    string filename = Console.ReadLine();

    using (StreamWriter writer = new StreamWriter(filename))
    {
        foreach (Transaction transaction in _transactions)
        {
            writer.WriteLine(transaction.GetType().Name);
            writer.WriteLine(transaction.GetDate());
            writer.WriteLine(transaction.GetDescription());
            writer.WriteLine(transaction.GetAmount());

            if (transaction is Expense)
            {
                Expense expense = (Expense)transaction;
                writer.WriteLine(expense.GetPurpose());
            }

            if (transaction is NoteEntry)
            {
                NoteEntry noteEntry = (NoteEntry)transaction;
                writer.WriteLine(noteEntry.GetPrompt());
                writer.WriteLine(noteEntry.GetEntry());
            }

            writer.WriteLine();
        }
    }

    Console.WriteLine("Transactions saved to file.");
}


// The LoadFromFile method prompts the user to enter a filename and loads the list of transactions from the file.
public void LoadFromFile()
{
    Console.Write("Enter the filename to load the transactions: ");
    string filename = Console.ReadLine();

    _transactions.Clear();

    if (File.Exists(filename))
    {
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string typeName = line;
                DateTime date = DateTime.Parse(reader.ReadLine());
                string description = reader.ReadLine();
                decimal amount = decimal.Parse(reader.ReadLine());

                Transaction transaction;

                if (typeName == "Expense")
                {
                    string purpose = reader.ReadLine();
                    transaction = new Expense(date, description, amount, purpose);
                }
                else if (typeName == "NoteEntry")
                {
                    string prompt = reader.ReadLine();
                    string entryText = reader.ReadLine();
                    transaction = new NoteEntry(date, prompt, amount, prompt, entryText);
                }
                else
                {
                    transaction = new Income(date, description, amount);
                }

                _transactions.Add(transaction);

                reader.ReadLine(); // Read and discard empty line
            }
        }

        Console.WriteLine("Transactions loaded from file.");
    }
    else
    {
        Console.WriteLine("File not found.");
    }
}
}