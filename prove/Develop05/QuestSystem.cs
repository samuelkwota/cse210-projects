class QuestSystem
{
    private List<Goal> goals = new List<Goal>();
    private int userScore = 0;

    public void CreateGoal(string name, int value, GoalType type, int targetCount = 0)
    {
        Goal newGoal;

        switch (type)
        {
            case GoalType.Simple:
                newGoal = new SimpleGoal(name, value);
                break;
            case GoalType.Eternal:
                newGoal = new EternalGoal(name, value);
                break;
            case GoalType.Checklist:
                newGoal = new ChecklistGoal(name, value, targetCount);
                break;
            default:
                throw new ArgumentException("Invalid goal type");
        }

        goals.Add(newGoal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            goals[goalIndex].RecordEvent();
            userScore += goals[goalIndex].Value;
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Goals:");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name} ({goals[i].GetGoalType()}) {goals[i].GetStatus()} - {goals[i].GetProgress()}");
        }
    }

    public void DisplayUserScore()
    {
        Console.WriteLine($"Total Score: {userScore}");
    }

    public void SaveGoals(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var goal in goals)
            {
                writer.WriteLine($"{goal.GetGoalType()},{goal.Name},{goal.Value},{goal.CurrentProgress},{goal.IsComplete}");
            }
        }
    }

    public void LoadGoals(string filePath)
    {
        try
        {
            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Read the content of the file
                string fileContent = File.ReadAllText(filePath);

                // Now, you can process the fileContent, which contains the goals data.
                // You might want to parse it, split it, or perform any other necessary actions.

                // For demonstration, let's just print the content to the console.
                Console.WriteLine("Goals loaded successfully:");
                Console.WriteLine(fileContent);
            }
            else
            {
                Console.WriteLine("The specified file does not exist.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}

enum GoalType
{
    Simple,
    Eternal,
    Checklist
}
