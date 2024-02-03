public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {                        
        DisplayStartingMessage();
        
        int counter = 0;
        while (counter < GetDuration())
        {
            
            Console.Write("Breathe in.....");
            ShowCountDown(GetDuration()/2);
            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountDown(GetDuration()/2);
            Console.WriteLine();

            counter += GetDuration();
        };
        
        DisplayEndingMessage();
        Console.Clear();  
    
    }
    
}
