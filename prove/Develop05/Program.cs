using System;
using System.Collections.Generic;

public class Program
{
    private static List<Goal> goals = new List<Goal>();
    private static int score = 0;

    public static void Main()
    {
        Console.WriteLine("Welcome to Goal Tracker!");

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Display Goals");
            Console.WriteLine("2. Create New Goal");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    DisplayGoals();
                    break;
                case "2":
                    CreateGoal();
                    break;
                case "3":
                    RecordEvent();
                    break;
                case "4":
                    DisplayScore();
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }                
    }

    // Method to display the goals
    public static void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        foreach (Goal goal in goals)
        {
            Console.WriteLine(goal.DisplayGoal());
        }
    }

    // Method to create a new goal
    public static void CreateGoal()
    {
        Console.WriteLine("What type of goal do you want to create?");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist goal");
        string input = Console.ReadLine();

        Console.WriteLine("What is the name of the goal?");
        string name = Console.ReadLine();

        Console.WriteLine("What is the point value of the goal?");
        int pointValue = int.Parse(Console.ReadLine());

        switch (input)
        {
            case "1":
                goals.Add(new SimpleGoal(name, pointValue));
            break;
            case "2":
                goals.Add(new EternalGoal(name, pointValue));
            break;
            case "3":
                Console.WriteLine("How many times does this goal need to be accomplished?");
                int numTimes = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, pointValue, numTimes));
            break;
            default:
                Console.WriteLine("Invalid input. Please try again.");
            break;
        }
    }

    // Method to record an event
    public static void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish?");
        int i = 1;
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"{i}. {goal.DisplayGoal()}");
            i++;
        }
        int selection = int.Parse(Console.ReadLine());

        Goal selectedGoal = goals[selection - 1];

        if (selectedGoal is SimpleGoal)
        {
            SimpleGoal simpleGoal = selectedGoal as SimpleGoal;
            if (!simpleGoal.Completed)
            {
                score += simpleGoal.MarkCompleted();
                Console.WriteLine($"Congratulations! You earned {simpleGoal.PointValue} points for completing {simpleGoal.Name}.");
            }
            else
            {
                Console.WriteLine("This goal has already been completed.");
            }
        }
        else if (selectedGoal is EternalGoal)
        {
            score += selectedGoal.CalculatePoints();
            Console.WriteLine($"Congratulations! You earned {selectedGoal.PointValue} points for recording {selectedGoal.Name}.");
        }
        else if (selectedGoal is ChecklistGoal)
        {
            ChecklistGoal checklistGoal = selectedGoal as ChecklistGoal;
            if (!checklistGoal.IsCompleted())
            {
                checklistGoal.RecordProgress();
                score += checklistGoal.CalculatePoints();
                Console.WriteLine($"Congratulations! You earned {checklistGoal.PointValue} points for recording progress on {checklistGoal.Name}.");
                if (checklistGoal.IsCompleted())
                {
                    Console.WriteLine($"You earned a bonus of {checklistGoal.PointValue} points for completing {checklistGoal.Name}.");
                }
            }
            else
            {
                Console.WriteLine("This goal has already been completed.");
            }
        }
    }

    // Method to display the score
    public static void DisplayScore()
    {
            Console.WriteLine($"Your score is {score}.");
    }

    // Method to save the goals and scores
    public static void SaveGoals()
    {
        // Implement saving functionality here
        GoalFileManager.SaveGoals(goals);
        Console.WriteLine("Goals and scores have been saved.");
    }

    // Method to load the goals and scores
    public static void LoadGoals()
    {
        // Implement loading functionality here
        List<Goal> loadedGoals = GoalFileManager.LoadGoals();
        foreach (Goal goal in loadedGoals)
        {
            Console.WriteLine(goal.ToString());
        }
        Console.WriteLine("Goals and scores have been loaded.");
    }
}











