using System;
using System.Collections.Generic;

public class ReflectionActivity
{
    // Method to start and run the reflection activity
    public static void Run(int duration)
    {
        // Show starting message and prompt for duration
        Console.WriteLine("Starting reflection activity...");
        Console.WriteLine("Please enter the duration of the activity in seconds:");

        // Read in duration from user input
        int remainingSeconds = duration;
        try
        {
            remainingSeconds = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Using default duration of {0} seconds.", duration);
        }

        // Describe the activity to the user
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.");
        Console.WriteLine("This will help you recognize the power you have and how you can use it in other aspects of your life.");

        // List of prompts and questions for reflection
        List<string> prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        List<string> questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        Random random = new Random();

        // Loop through prompts and questions until time is up
        while (remainingSeconds > 0)
        {
            // Choose a random prompt
            string prompt = prompts[random.Next(prompts.Count)];
            Console.WriteLine(prompt);

            // Pause and show spinner
            int count = 3;
            while (count > 0)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(500);
                count--;
            }
            Console.WriteLine();

            // Choose random questions for reflection
            string question1 = questions[random.Next(questions.Count)];
            string question2 = questions[random.Next(questions.Count)];

            // Ask questions and pause between each one
            Console.WriteLine(question1);
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine(question2);
            System.Threading.Thread.Sleep(2000);

            // Update remaining time
            remainingSeconds -= 4;
        }

        // Show finishing message
        Console.WriteLine("Reflection activity complete. Well done!");
    }
}
