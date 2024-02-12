public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int point):base(shortName, description, point)
    {}

    public override void RecordEvent()
    {
        int score = 0;
        score += GetPoint();
        Console.WriteLine($"Congratulations!..... You have earned {score} points.");
    }

    public override bool IsComplete()
    {
        return false;
    }     

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{GetShortName()}|{GetDescription()}|{GetPoint()}";
    }
}