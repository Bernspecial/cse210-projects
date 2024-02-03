// Added a this activity to the user opportunity to think of a wprd and later say out loud to their hear.
public class MeditationActivity : Activity
{
    public MeditationActivity(string name, string description) : base(name, description)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        int counter = 0;
        while (counter < GetDuration())
        {
            Console.Write("Think of any word.......");
            ShowCountDown(GetDuration() / 2);
            Console.WriteLine();
            Console.Write("Now say the word out loud.....");
            ShowCountDown(GetDuration() / 2);
            Console.WriteLine();

            counter += GetDuration();
        };

        DisplayEndingMessage();
        Console.Clear();
    }
}