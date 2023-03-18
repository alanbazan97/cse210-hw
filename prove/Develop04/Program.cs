using System;

class Program
{
    static void Main()
    {
        // prompt user to select an activity
        Console.WriteLine("Welcome! What type of activity would you like to do? Enter 1 for Breathing, 2 for Reflection, or 3 for Listing.");
        string activityType = Console.ReadLine();

        // create an instance of the selected activity and run it
        if (activityType == "1")
        {
            BreathingActivity activity = new BreathingActivity();
            BreathingActivity.Run();
        }
        else if (activityType == "2")
        {
            ReflectionActivity activity = new ReflectionActivity();
            ReflectionActivity.Run(60);
        }
        else if (activityType == "3")
        {
            ListingActivity activity = new ListingActivity();
            ListingActivity.Run();
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Main();
        }
    }
}
