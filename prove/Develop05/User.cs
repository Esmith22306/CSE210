public class User 
{   
    public string Username { get;}
    public List<Goal> GoalsList { get; }
    public int TotalScore {get; protected set;}

    //Constructor
    public User(string username)
    {
        Username = username;
        GoalsList =  new List<Goal>();
        TotalScore = 0;
    }

    public void SetGoalsManually()
    {
        Console.WriteLine("Enter the number of goals you want to create:");
        int count;
        while (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"\nEnter details for Goal {i + 1}:");
            Console.WriteLine("Enter goal name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter goal type (Simple, Eternal, or Checklist):");
            string type = Console.ReadLine();

            Console.WriteLine("Enter points for the goal:");
            int points;
            while (!int.TryParse(Console.ReadLine(), out points) || points <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer for points.");
            }

            switch (type.ToLower())
            {
                case "simple":
                    GoalsList.Add(new SimpleGoal(name, points));
                    break;
                case "eternal":
                    Console.WriteLine("Enter frequency for the eternal goal:");
                    int frequency;
                    while (!int.TryParse(Console.ReadLine(), out frequency) || frequency <= 0)
                    {
                        Console.WriteLine("Invalid input. Please enter a positive integer for frequency.");
                    }
                    GoalsList.Add(new EternalGoal(name, points, frequency));
                    break;
                case "checklist":
                    Console.WriteLine("Enter total occurrences for the checklist goal:");
                    int totalOccurrences;
                    while (!int.TryParse(Console.ReadLine(), out totalOccurrences) || totalOccurrences <= 0)
                    {
                        Console.WriteLine("Invalid input. Please enter a positive integer for total occurrences.");
                    }
                    GoalsList.Add(new ChecklistGoal(name, points, totalOccurrences));
                    break;
                default:
                    Console.WriteLine("Invalid goal type. Skipping this goal.");
                    break;
            }
        }
    }


    public void RecordEvent(string goalName)
    {
        var goal = GoalsList.FirstOrDefault(g => g.Name == goalName);
        if (goal != null && !goal.IsComplete)
        {
            goal.MarkComplete();
            TotalScore += goal.Points + goal.BonusPoints;
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Current Goals:");
        foreach (var goal in GoalsList)
        {
            Console.WriteLine($"{goal.Name} - Type: {goal.Type}, Points: {goal.Points}, Completion: {(goal.IsComplete ? "Complete" : "Incomplete")}, Progress: {goal.Progress}%");
        }
        Console.WriteLine($"Total Score: {TotalScore}");
    }

    public void SaveData(string fileName)
    {
        // Implement saving data to file
    }

    public void LoadData(string fileName)
    {
        // Implement loading data from file
    }

}