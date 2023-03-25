using System;
public class Goal
{
    // Private member variables
    private string _name;
    private int _pointValue;

    // Public properties
    public string Name { get { return _name; } }
    public int PointValue { get { return _pointValue; } }

    // Constructor
    public Goal(string name, int pointValue)
    {
        _name = name;
        _pointValue = pointValue;
    }

    // Method to display the goal
    public virtual string DisplayGoal()
    {
        return $"{_name} ({_pointValue} points)";
    }

    // Method to calculate points earned
    public virtual int CalculatePoints()
    {
        return _pointValue;
    }
}

