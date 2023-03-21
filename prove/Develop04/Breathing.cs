using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base(duration) {}

    public override void Start()
    {
        Console.WriteLine("Starting breathing activity...");
        Console.WriteLine("Duration: " + duration + " seconds");
        Thread.Sleep(2000); // pause for 2 seconds
        Console.WriteLine("Take a deep breath in...");
        Thread.Sleep(2000); // pause for 2 seconds
        Console.WriteLine("Hold your breath...");
        Thread.Sleep(2000); // pause for 2 seconds
        Console.WriteLine("Exhale slowly...");
        Thread.Sleep(2000); // pause for 2 seconds
        Console.WriteLine("Repeat until the end of the activity.");
        Thread.Sleep(2000); // pause for 2 seconds
    }

    public override void End(string activityName, int duration)
    {
        base.End(activityName, duration);
        Console.WriteLine("Remember to take deep breaths throughout your day!");
        Thread.Sleep(2000); // pause for 2 seconds
    }
}








