using System;

public static class GoalFileManager
{
    private const string FILE_NAME = "goals.txt";

    public static void SaveGoals(List<Goal> goals)
    {
        using (StreamWriter writer = new StreamWriter(FILE_NAME))
        {
            foreach (Goal goal in goals)
            {
                if (goal is SimpleGoal)
                {
                    SimpleGoal simpleGoal = (SimpleGoal)goal;
                    writer.WriteLine($"simple,{simpleGoal.Name},{simpleGoal.PointValue},{simpleGoal.Completed}");
                }
                else if (goal is EternalGoal)
                {
                    EternalGoal eternalGoal = (EternalGoal)goal;
                    writer.WriteLine($"eternal,{eternalGoal.Name},{eternalGoal.PointValue}");
                }
                else if (goal is ChecklistGoal)
                {
                    ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                    writer.WriteLine($"checklist,{checklistGoal.Name},{checklistGoal.PointValue},{checklistGoal.NumTimes},{checklistGoal.NumCompleted}");
                }
            }
        }
    }

    public static List<Goal> LoadGoals()
    {
        List<Goal> goals = new List<Goal>();

        if (!File.Exists(FILE_NAME))
        {
            return goals;
        }

        using (StreamReader reader = new StreamReader(FILE_NAME))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] parts = line.Split(',');

                if (parts.Length < 3)
                {
                    continue;
                }

                string type = parts[0];
                string name = parts[1];
                int pointValue = int.Parse(parts[2]);

                switch (type)
                {
                    case "simple":
                        bool completed = bool.Parse(parts[3]);
                        SimpleGoal simpleGoal = new SimpleGoal(name, pointValue);
                        simpleGoal.MarkCompleted();
                        goals.Add(simpleGoal);
                        break;
                    case "eternal":
                        EternalGoal eternalGoal = new EternalGoal(name, pointValue);
                        goals.Add(eternalGoal);
                        break;
                    case "checklist":
                        int numTimes = int.Parse(parts[3]);
                        int numCompleted = int.Parse(parts[4]);
                        ChecklistGoal checklistGoal = new ChecklistGoal(name, pointValue, numTimes);
                        for (int i = 0; i < numCompleted; i++)
                        {
                            checklistGoal.RecordProgress();
                        }
                        goals.Add(checklistGoal);
                        break;
                }
            }
        }

        return goals;
    }
}
