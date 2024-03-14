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