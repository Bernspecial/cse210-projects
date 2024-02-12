public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _point;

    public Goal(string shortName, string description, int point)
    {
        _shortName = shortName;
        _description = description;
        _point = point;
    }

    public string GetShortName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoint()
    {
        return _point;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();
    
    public virtual string GetDetailsString()
    {
        return $"{_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();


}