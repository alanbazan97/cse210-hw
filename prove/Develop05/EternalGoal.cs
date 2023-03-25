using System;
public class EternalGoal : Goal
{
    // Constructor
    public EternalGoal(string name, int pointValue) : base(name, pointValue)
    {
    }

    // Override method to display the goal
    public override string DisplayGoal()
    {
        return base.DisplayGoal() + " (Eternal)";
    }

    // Override method to calculate points earned
    public override int CalculatePoints()
    {
        return base.CalculatePoints();
    }
}
