using System;
public class SimpleGoal : Goal
{
    // Private member variable
    private bool _completed;

    // Public property
    public bool Completed { get { return _completed; } }

    // Constructor
    public SimpleGoal(string name, int pointValue) : base(name, pointValue)
    {
        _completed = false;
    }

    // Method to mark goal as completed and return earned points
    public int MarkCompleted()
    {
        _completed = true;
        return CalculatePoints();
    }

    // Method to display the goal with completion status
    public override string DisplayGoal()
    {
        string status = _completed ? "[X]" : "[ ]";
        return $"{status} {base.DisplayGoal()}";
    }
}

