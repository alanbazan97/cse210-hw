using System;
public class ChecklistGoal : Goal
{
    // Private member variables
    private int _numTimes;
    private int _numCompleted;
    
    // Public properties
    public int NumTimes { get { return _numTimes; } }
    public int NumCompleted { get { return _numCompleted; } }

    // Constructor
    public ChecklistGoal(string name, int pointValue, int numTimes)
        : base(name, pointValue)
    {
        _numTimes = numTimes;
        _numCompleted = 0;
    }

    // Method to display the goal
    public override string DisplayGoal()
    {
        return $"{base.DisplayGoal()} [{_numCompleted}/{_numTimes}]";
    }

    // Method to calculate points earned
    public override int CalculatePoints()
    {
        if (_numCompleted >= _numTimes)
        {
            // Bonus points for finishing the goal
            return base.CalculatePoints() * 2;
        }
        else
        {
            // Regular points for partial progress
            return base.CalculatePoints();
        }
    }

    // Method to record progress
    public void RecordProgress()
    {
        if (_numCompleted < _numTimes)
        {
            _numCompleted++;
        }
    }

    // Method to check if goal is completed
    public bool IsCompleted()
    {
        return _numCompleted >= _numTimes;
    }
}






