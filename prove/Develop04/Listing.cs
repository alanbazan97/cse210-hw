using System;
using System.Threading;

public class ListingActivity : Activity
{
    private string prompt;
    private int itemCount;

    public ListingActivity(int duration, string prompt) : base(duration)
    {
        this.prompt = prompt;
    }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("Prompt: " + prompt);
        Thread.Sleep(3000); // pause for 3 seconds
        Console.WriteLine("Begin listing...");
        Thread.Sleep(2000); // pause for 2 seconds
    }

    public override void End(string activityName, int duration)
    {
        Console.WriteLine("Congratulations! You've listed " + itemCount + " items in the " + activityName + " activity.");
        base.End(activityName, duration);
    }

    public void ListItems()
    {
        Console.WriteLine("Enter items or type 'done' to finish:");
        string input = Console.ReadLine();

        while (input != "done")
        {
            itemCount++;
            input = Console.ReadLine();
        }
    }
}




