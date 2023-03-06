using System;
using System.IO;


class Program
{

    static void Main(string[] args)
    {
        int[] validNumbers = { 1, 2, 3, 4, 5 };
        int action = 0;
        Console.Write("Welcome to the Journal App");
        
        Journal journal = new Journal();
        JournalPrompt journalPrompt = new JournalPrompt();

        while (action != 5)
        {
            action = Choices();

            switch (action) 
            {
                case 1:
                    string entryId = GetEntryId();
                    string dateInfo = GetDateTime();
                    string prompt = journalPrompt.GetPrompt();

                    JournalEntry entry = new JournalEntry();
                    entry._entryNumber = entryId;
                    entry._dateTime = dateInfo;
                    entry._journalPrompt = prompt;
                    Console.Write($"{prompt}");
                    string userEntry = Console.ReadLine();
                    entry._journalEntry = userEntry;
                    journal._journal.Add(entry);
                    break;
                case 2:
                    journal.Display();
                    break;
                case 3: 
                    journal.CreateJournalFile();
                    break; 
                case 4:
                    journal.LoadJournalFile();
                    break;
                case 5:
                    Console.WriteLine("Thank you for using the Journal App!");
                    break;
                default:
                    Console.WriteLine("I'm sorry, the option you entered is not valid.");
                    break;
            }
        }
    }
    static int Choices()
    {
        string choices = @"
Please select one of the following choices:
1. Write
2. Display
3. Save
4. Load
5. Quit
What would you like to do? ";

        Console.Write(choices);
        string userInput = Console.ReadLine();
        int action = int.Parse(userInput);
        return action;
    }

    static string GetDateTime()
    {
        DateTime now = DateTime.Now;
        string currentDateTime = now.ToShortDateString();
        return currentDateTime;
    }
    static void AddJournalEntry()
    {
        string MyJournalFile = "MyJournal.txt";
        File.AppendAllText(MyJournalFile, "");
    }

    static string GetEntryId()
    {
        Guid entryuuid = Guid.NewGuid();
        string entryuuidAsString = entryuuid.ToString();

        return entryuuidAsString;
    }
}