public class HabitGoal : Goal
{
    private bool _isComplete;

    public HabitGoal(string shortName, string description, int point):base(shortName, description, point)
    {

    }

     public HabitGoal(string shortName, string description, int point, bool complete):base(shortName, description, point)
    {
        _isComplete = complete;
    }

    public override void RecordEvent()
    {
        int score = 0;

        if (!IsComplete())
        {
            _isComplete = true;
            score += GetPoint();
        }
        
        Console.WriteLine($"Congratulations!..... You have earned {score} points.");
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }
    

    public override string GetStringRepresentation()
    {
        return $"HabitGoal|{GetShortName()}|{GetDescription()}|{GetPoint()}|{IsComplete()}";
    }
}