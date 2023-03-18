using System;
using System.Threading;

// Base class for all activities
public abstract class Activity
{
    // Private member variables to store the name and duration of the activity
    private string _name;
    private int _duration;

    // Constructor to set the name and duration of the activity
    public Activity(string name, int duration)
    {
        _name = name;
        _duration = duration;
    }

    // Method to start the activity
    public void Start()
    {
        // Display the starting message for the activity
        Console.WriteLine($"Starting {_name} for {_duration} seconds...");
        Console.WriteLine(StartingMessage());

        // Pause for a few seconds to allow the user to prepare
        Pause(3);

        // Start the activity loop
        ActivityLoop();

        // Display the ending message for the activity
        Console.WriteLine(EndingMessage());
        Console.WriteLine($"You completed {_name} for {_duration} seconds.");
    }

    // Abstract methods to be implemented by each activity class
    protected abstract string StartingMessage();
    protected abstract string EndingMessage();
    protected abstract void ActivityLoop();

    // Method to pause the program for a specified number of seconds
    protected void Pause(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}

