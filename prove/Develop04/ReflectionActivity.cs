using System;

public class ReflectionActivity : Activity
{
    private string[] _prompts = new string[]
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    
    private string[] _questions = new string[]
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

    public ReflectionActivity(int duration) : base(duration)
    {
        Description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public override void Run()
    {
        Console.WriteLine(Description);
        Console.WriteLine("Press any key to begin...");
        Console.ReadKey();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Length)];
        Console.WriteLine(prompt);
        Thread.Sleep(2000);

        int index = 0;
        while (TimeLeft.TotalSeconds > 0)
        {
            string question = _questions[index];
            Console.WriteLine(question);
            Thread.Sleep(2000);

            index = (index + 1) % _questions.Length;
        }

        Console.WriteLine("Time's up! You reflected on {0} questions.", _questions.Length);
        base.Run();
    }
}



