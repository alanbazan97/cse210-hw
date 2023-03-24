using System;
public class EternalGoal : Goal
{
    public int TotalPointsEarned { get; set; }

    public EternalGoal(string title, int pointValue) : base(title, pointValue)
    {
        TotalPointsEarned = 0;
    }

    public override void MarkComplete()
    {
        base.MarkComplete();
        TotalPointsEarned += PointValue;
    }

    public override string ToString()
    {
        return $"{Title} (total points earned: {TotalPointsEarned})";
    }
}

