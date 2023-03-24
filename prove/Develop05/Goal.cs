using System;
public class Goal
{
    public string Title { get; set; }
    public int PointValue { get; set; }
    public bool IsComplete { get; set; }

    public Goal(string title, int pointValue)
    {
        Title = title;
        PointValue = pointValue;
        IsComplete = false;
    }

    public virtual void MarkComplete()
    {
        IsComplete = true;
    }

    public override string ToString()
    {
        return $"{Title} ({PointValue} points)";
    }
}

