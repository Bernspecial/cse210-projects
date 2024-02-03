public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine($"{_description}");
        Console.Write("How many seconds would you like for your session? ");
        string duration = Console.ReadLine();
        _duration = int.Parse(duration);
        Console.WriteLine("Get ready...\n");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!\n");
        Console.WriteLine($"You have completed the {_name} activity.");
        Console.WriteLine($"It lasted for {_duration} seconds.\n");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationString = new List<string>{"|","/","-","\\"};
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string second = animationString[i];
            Console.Write(second);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationString.Count)
            {
                i = 0;
            }
        }
    }
    
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }
}
