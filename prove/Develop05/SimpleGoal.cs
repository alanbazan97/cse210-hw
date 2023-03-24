using System;
public class SimpleGoal : Goal
{
    public SimpleGoal(string title, int pointValue) : base(title, pointValue)
    {
    }

    public override void MarkComplete()
    {
        base.MarkComplete();
        Console.WriteLine($"Congratulations, you completed the goal: {Title}!");
    }
}

