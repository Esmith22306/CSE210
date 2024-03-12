using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Goal base class
public abstract class Goal
{
    public string Name { get; set; }
    public string Type { get; }
    public int Points { get; }
    public bool IsComplete { get; protected set; }
    public int Progress { get; protected set; }
    public int BonusPoints { get; protected set; }

    public Goal(string name, string type, int points)
    {
        Name = name;
        Type = type;
        Points = points;
        IsComplete = false;
        Progress = 0;
        BonusPoints = 0;
    }

    public virtual void MarkComplete()
    {
        if (!IsComplete)
        {
            IsComplete = true;
            CalculatePoints();
        }
    }

    protected abstract void CalculatePoints();
}

// SimpleGoal class
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, "Simple", points) { }

    protected override void CalculatePoints()
    {
        BonusPoints = 10; // Bonus points for completing a simple goal
    }
}

// EternalGoal class
public class EternalGoal : Goal
{
    public int Frequency { get; }

    public EternalGoal(string name, int points, int frequency) : base(name, "Eternal", points)
    {
        Frequency = frequency;
    }

    protected override void CalculatePoints()
    {
        // Implement points calculation for eternal goal
        BonusPoints = 20; // Example bonus points for completing an eternal goal
    }
}

// ChecklistGoal class
public class ChecklistGoal : Goal
{
    public int TotalOccurrences { get; }
    public int CurrentOccurrences { get; private set; }

    public ChecklistGoal(string name, int points, int totalOccurrences) : base(name, "Checklist", points)
    {
        TotalOccurrences = totalOccurrences;
        CurrentOccurrences = 0;
    }

    public void CheckCompletion()
    {
        if (CurrentOccurrences < TotalOccurrences)
        {
            CurrentOccurrences++;
            Progress = (int)Math.Round((double)CurrentOccurrences / TotalOccurrences * 100);
            if (CurrentOccurrences == TotalOccurrences)
                MarkComplete();
        }
    }

    protected override void CalculatePoints()
    {
        // Implement points calculation for checklist goal
        BonusPoints = 15; // Example bonus points for completing a checklist goal
    }
}

// User class
public class User
{
    public string Username { get; }
    public List<Goal> GoalsList { get; }
    public int TotalScore { get; private set; }

    public User(string username)
    {
        Username = username;
        GoalsList = new List<Goal>();
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

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Eternal Quest!");
        Console.WriteLine("Enter your username:");
        string username = Console.ReadLine();

        User user = new User(username);

        // Example goal creation
        user.CreateGoal("Read a book", "simple", 50);
        user.CreateGoal("Exercise", "eternal", 100, 3); // 3 times per week
        user.CreateGoal("Learn to cook", "checklist", 80, totalOccurrences: 10); // 10 different recipes

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Record Completed Event");
            Console.WriteLine("2. View Goals and Scores");
            Console.WriteLine("3. Save Data");
            Console.WriteLine("4. Load Data");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Choose an option:");

            int option;
            if (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Invalid option. Please enter a number.");
                continue;
            }

            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter the name of the goal you completed:");
                    string goalName = Console.ReadLine();
                    user.RecordEvent(goalName);
                    break;
                case 2:
                    user.DisplayGoals();
                    break;
                case 3:
                    Console.WriteLine("Enter the filename to save data:");
                    string saveFileName = Console.ReadLine();
                    user.SaveData(saveFileName);
                    Console.WriteLine("Data saved successfully.");
                    break;
                case 4:
                    Console.WriteLine("Enter the filename to load data:");
                    string loadFileName = Console.ReadLine();
                    user.LoadData(loadFileName);
                    Console.WriteLine("Data loaded successfully.");
                    break;
                case 5:
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please choose a number from the menu.");
                    break;
            }
        }
    }
}
