using System;
public class ChecklistGoal : Goal
{
    public int Progress { get; set; }
    public int Target { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string title, int pointValue, int target, int bonusPoints) : base(title, pointValue)
    {
        Progress = 0;
        Target = target;
        BonusPoints = bonusPoints;
    }

    public override void MarkComplete()
    {
        Progress++;
        if (Progress == Target)
        {
            IsComplete = true;
            PointValue += BonusPoints;
        }
    }

    public override string ToString()
    {
        string completionStatus = IsComplete ? "Completed" : "Incomplete";
        return $"{Title} ({PointValue} points) - {completionStatus} ({Progress}/{Target})";
    }
}






