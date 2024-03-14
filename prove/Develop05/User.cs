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

    public void CreateGoal(string name, string type, int points, int frequency = 0, int totalOccurrences = 0)
    {
        Goal goal;
        switch (type.ToLower())
        {
            case "simple":
                goal = new SimpleGoal(name, points);
                break;
            case "eternal":
                goal = new EternalGoal(name, points, frequency);
                break;
            case "checklist":
                goal = new ChecklistGoal(name, points, totalOccurrences);
                break;
            default:
                throw new ArgumentException("Invalid goal type");
        }
        GoalsList.Add(goal);
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