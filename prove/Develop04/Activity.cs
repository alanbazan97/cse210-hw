using System;
using System.Threading;

// Base class for all activities
public class Activity
{
    protected int duration;

    public Activity(int duration)
    {
        this.duration = duration;
    }

    public virtual void Start()
    {
        Console.WriteLine("Starting activity...");
        Console.WriteLine("Duration: " + duration + " seconds");
        Thread.Sleep(2000); // pause for 2 seconds
        Console.WriteLine("Get ready to begin...");
        Thread.Sleep(2000); // pause for 2 seconds
    }

    public virtual void End(string activityName, int duration)
    {
        Console.WriteLine("Congratulations! You've completed the " + activityName + " activity.");
        Console.WriteLine("Total duration: " + duration + " seconds");
        Thread.Sleep(2000); // pause for 2 seconds
    }
}



