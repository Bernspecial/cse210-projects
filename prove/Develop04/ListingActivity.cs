public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    public ListingActivity(string name, string description) : base(name, description)
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {        
        DisplayStartingMessage();
        GetRandomPrompt();
        DisplayEndingMessage();      
        Console.Clear();  
    }

    public void GetRandomPrompt()
    {
    Random random = new Random();
    int randomIndex = random.Next(_prompts.Count);
    Console.WriteLine("List as many responses you can to the following prompt.");
    Console.WriteLine($"------{_prompts[randomIndex]}------");
    Console.WriteLine();
    Console.WriteLine("You may begin in 5 seconds.");
    ShowCountDown(5);

    DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

    while (DateTime.Now < endTime)
    {        
        GetListFromUser();
        _count++;
        
    }
    Console.WriteLine($"You listed {_count} items.");


    Console.WriteLine();
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        {
            Console.Write(">");
            string item = Console.ReadLine();
            items.Add(item);         
        }
        return items;
    }

    
}
