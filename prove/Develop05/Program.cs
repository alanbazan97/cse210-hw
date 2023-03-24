using System;
using System.Collections.Generic;

class Program
{
    static List<Goal> goals = new List<Goal>();

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Eternal Quest!");

        // Add some sample goals
        goals.Add(new SimpleGoal("Run a marathon", 1000));
        goals.Add(new EternalGoal("Read scriptures", 100));
        goals.Add(new ChecklistGoal("Attend the temple", 50, 10, 100));

        // Display the list of goals
        DisplayGoals();

        // Allow the user to create new goals
        while (true)
        {
            Console.WriteLine("Enter a new goal title or press ENTER to exit:");
            string title = Console.ReadLine();
            if (title == "") break;

            Console.WriteLine("Enter the point value for this goal:");
            int pointValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Select the type of goal:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            int type = int.Parse(Console.ReadLine());

            switch (type)
            {
                case 1:
                    goals.Add(new SimpleGoal(title, pointValue));
                    break;
                case 2:
                    goals.Add(new EternalGoal(title, pointValue));
                    break;
                case 3:
                    Console.WriteLine("Enter the target number of completions:");
                    int target = int.Parse(Console.ReadLine());
                    goals.Add(new ChecklistGoal(title, pointValue, target, 100));
                    break;
            }
        }

        // Allow the user to mark goals as complete
        while (true)
        {
            Console.WriteLine("Enter the number of the goal you completed or press ENTER to exit:");
            string input = Console.ReadLine();
            if (input == "") break;

            int index = int.Parse(input) - 1;
            goals[index].MarkComplete();
            Console.WriteLine($"Congratulations, you earned {goals[index].PointValue} points!");
        }

        // Display the list of goals and the user's score
        DisplayGoals();
        Console.WriteLine($"Your current score is {GetScore()} points.");
    }

    static void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            string status = goals[i].IsComplete ? "[X]" : "[ ]";
            if (goals[i] is ChecklistGoal)
            {
                int progress = ((ChecklistGoal)goals[i]).Progress;
                Console.WriteLine($"{status} {goals[i].Title} ({goals[i].PointValue} points) - Completed {progress}/{((ChecklistGoal)goals[i]).Target} times");
            }
            else
            {
                Console.WriteLine($"{status} {goals[i].Title} ({goals[i].PointValue} points)");
            }
        }
    }

    static int GetScore()
    {
        int score = 0;
        foreach (Goal goal in goals)
        {
            if (goal.IsComplete)
            {
                score += goal.PointValue;
            }
        }
        return score;
    }
}










