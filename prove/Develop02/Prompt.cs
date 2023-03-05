using System;

public class JournalPrompt
{
    public static string[] _prompt = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What's one thing you're grateful for today?",
            "Have you done any good thing today?",
            "An adjective to describe your day?"
    };
    public List<string> _journalPrompt = new List<string>(_prompt);
    public JournalPrompt()
    {
    }

    public void Display()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[index];
        Console.WriteLine($"{_journalPrompt}");
    }
    public string GetPrompt()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[index];
        
        return journalPrompt;
    }
}