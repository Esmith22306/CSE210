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