using System;
public class MainMenuActivity : Activity
{
    public MainMenuActivity(int duration) : base(duration)
    {
    }

    public override void Start()
    {
        Console.WriteLine("Welcome to the main menu!");
        Console.WriteLine("Please select an activity to begin:");
        Console.WriteLine("1. Breathing");
        Console.WriteLine("2. Reflection");
        Console.WriteLine("3. Listing");
        Console.WriteLine("Enter the number of the activity you want to do:");
        // Additional implementation for starting the activity goes here...
        base.Start(); // Call the base implementation of the Start method
    }

    public override void End(string activityName, int duration)
    {
        // Additional implementation for ending the activity goes here...
        base.End(activityName, duration); // Call the base implementation of the End method
    }
}
