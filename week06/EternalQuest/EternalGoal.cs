public class EternalGoal : Goal
{
    private int _timesRecorded;

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _timesRecorded = 0;
    }

    public EternalGoal(string name, string description, int points, int timesRecorded) : base(name, description, points)
    {
        _timesRecorded = timesRecorded;
    }

    public override void RecordEvent()
    {
        _timesRecorded++;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public int GetTimesRecorded()
    {
        return _timesRecorded;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points},{_timesRecorded}";
    }
}
