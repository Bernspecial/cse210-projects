public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description) : base(name, description)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void Run()
    {

        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"----{prompt}----");

        Console.WriteLine("When you have something to say, press enter to conitnue: ");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You begin in.....");
        ShowCountDown(5);
        Console.WriteLine();
        

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        { 
            string question = GetRandomQuestion();
            Console.WriteLine(question);
            ShowSpinner(GetDuration()/2); // Pause for several seconds with spinner

            if (DateTime.Now >= endTime) break;
        }

        DisplayEndingMessage();
        Console.Clear();  

        
    }

    public string GetRandomPrompt()
    { return _prompts[new Random().Next(_prompts.Count)];
    }
    public string GetRandomQuestion() 

    {
        return _questions[new Random().Next(_questions.Count)];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }
    public void DisplayQuestion()
    {
        Console.WriteLine(GetRandomQuestion());
    }

}
