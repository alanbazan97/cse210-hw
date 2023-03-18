using System;

public class ListingActivity
{
    public static void Run()
    {
        Console.WriteLine("Starting Listing Activity...");

        // Prompt user for duration of activity
        Console.Write("How many seconds would you like for this activity? ");
        int duration = Convert.ToInt32(Console.ReadLine());

        // Prompt user with a random prompt
        string[] prompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        Random rnd = new Random();
        int promptIndex = rnd.Next(prompts.Length);
        Console.WriteLine(prompts[promptIndex]);

        // Start timer
        DateTime startTime = DateTime.Now;

        // Countdown for user to start listing items
        Console.WriteLine("Think about the prompt above for a few seconds, then press enter to start listing items.");
        Console.ReadLine();

        // Initialize item count
        int itemCount = 0;

        // Loop through and prompt user to list items until time is up
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.Write("Enter an item: ");
            Console.ReadLine();
            itemCount++;
        }

        // Display number of items listed
        Console.WriteLine($"You listed {itemCount} items.");

        Console.WriteLine("Listing Activity complete.");
    }
}
