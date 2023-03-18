using System;
using System.Threading;

public class BreathingActivity
{
    public static void Run()
    {
        Console.WriteLine("Welcome to the Breathing Activity");
        int duration = PromptForDuration();

        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

        // loop for the duration of the activity
        for (int i = 0; i < duration; i++)
        {
            // alternate between "Breathe in..." and "Breathe out..."
            if (i % 2 == 0)
            {
                Console.WriteLine("Breathe in...");
            }
            else
            {
                Console.WriteLine("Breathe out...");
            }

            // pause for a few seconds and show a countdown
            Countdown(3);
        }

        Console.WriteLine("Great job! You have completed the Breathing Activity.");
    }

    private static int PromptForDuration()
    {
        Console.WriteLine("How many seconds would you like to do this activity for?");
        string input = Console.ReadLine();
        int duration;
        while (!int.TryParse(input, out duration) || duration <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer value.");
            input = Console.ReadLine();
        }
        return duration;
    }

    private static void Countdown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write($" {i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
