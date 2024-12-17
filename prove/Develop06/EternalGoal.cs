using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }
    public override void RecordEvent()
    {
        // Eternal goals are never "complete"
    }
    public override bool IsComplete()
    {
        return false; // Eternal goals are never completed
    }
    public override string GetDetailsString()
    {
        return $"[ ] {_shortName}: {_description} (Eternal Goal)";
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal,{_shortName},{_description},{_points}";
    }
}
