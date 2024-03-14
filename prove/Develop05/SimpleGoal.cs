public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, "Simple", points) { }

    protected override void CalculatePoints()
    {
        BonusPoints = 10; // Bonus points for completing a simple goal
    }
}