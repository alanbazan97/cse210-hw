using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base("Breathing Activity", duration) { }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Thread.Sleep(2000);

        int secondsElapsed = 0;
        while (secondsElapsed < Duration)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(2000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(2000);

            secondsElapsed += 4;
        }

        base.End();
    }
}

