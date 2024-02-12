public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string shortName, string description, int point, int bonus, int target):base(shortName, description, point)
    {
        _bonus = bonus;
        _target = target;
        _amountCompleted = 0;
    }

    public CheckListGoal(string shortName, string description, int point, int bonus, int target, int amountCompleted):base (shortName, description, point)
        {
            _bonus = bonus;
            _target = target;
            _amountCompleted = amountCompleted;

        }


    public int GetTarget()
    {
        return _target;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public override void RecordEvent()
    {
        int score = 0;
        _amountCompleted++;
        if (IsComplete())
        {
            score += GetPoint() + (_bonus * (_amountCompleted - _target));
        }
        else
        {
            score += GetPoint();
        }
        Console.WriteLine($"Congratulations!..... You have earned {score} points.");
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }


    public override string GetDetailsString()
    {
        return $"{GetShortName()} - {GetDescription()} - Currrnetly Completed: {GetAmountCompleted()}/{GetTarget()}";
    }
    

    public override string GetStringRepresentation()
    {
        return $"CheckListGoal|{GetShortName()}|{GetDescription()}|{GetPoint()}|{GetBonus()}|{GetTarget()}|{GetAmountCompleted()}";
        // return $"CheckListGoal|{GetShortName()}|{GetDescription()}|{GetPoint()}";
    }
}