public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, int point):base(shortName, description, point)
    {
        _isComplete = false;
    }

    public SimpleGoal(string shortName, string description, int point, bool isComplete):base(shortName, description, point)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        int score = 0;
        
        // if (IsComplete())
        // {
        //     score += GetPoint();
        // }

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
        return $"SimpleGoal|{GetShortName()}|{GetDescription()}|{GetPoint()}|{IsComplete()}";
    }
}