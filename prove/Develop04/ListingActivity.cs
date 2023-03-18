using System;
using System.Threading;

public class ListingActivity : Activity
{
    private string prompt;
    private int duration;

    public ListingActivity(string name, string prompt, int duration) : base(name)
    {
        this.prompt = prompt;
        this.duration = duration;
    }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine($"Duration: {duration} seconds");

        int count = 0;
        Console.WriteLine("Begin listing:");
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.Write($"{count + 1}. ");
            string item = Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items.");
        base.Finish();
    }
}


