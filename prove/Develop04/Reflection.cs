using System;

public class ReflectionActivity : Activity
{
    private string[] prompts = new string[] { 
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless." 
    };

    private string[] questions = new string[] {
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
    }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.");
        Console.WriteLine("This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Thread.Sleep(2000); // pause for 2 seconds
    }

    public override void End(string activityName, int duration)
    {
        base.End(activityName, duration);
    }

    public void PromptUser()
    {
        Random rnd = new Random();
        int promptIndex = rnd.Next(0, prompts.Length);
        Console.WriteLine(prompts[promptIndex]);
        Thread.Sleep(2000); // pause for 2 seconds

        int questionIndex = 0;
        int timeElapsed = 0;
        while (timeElapsed < duration)
        {
            Console.WriteLine(questions[questionIndex]);
            Thread.Sleep(2000); // pause for 2 seconds
            timeElapsed += 2;
            questionIndex = (questionIndex + 1) % questions.Length;
        }
    }
}



