using System;

public class MainMenu : Activity
{
    public override void Start()
    {
        Console.WriteLine("Welcome to the relaxation app!");
        Console.WriteLine("Please choose an activity:");
        Console.WriteLine("1. Breathing Exercise");
        Console.WriteLine("2. Reflection Exercise");
        Console.WriteLine("3. Listing Exercise");

        string input = Console.ReadLine();
        switch (input)
        {
            case "1":
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Start();
                break;
            case "2":
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.Start();
                break;
            case "3":
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Start();
                break;
            default:
                Console.WriteLine("Invalid input, please try again.");
                Start();
                break;
        }
    }

    public override void End()
    {
        Console.WriteLine("Thank you for using the relaxation app!");
    }
}


