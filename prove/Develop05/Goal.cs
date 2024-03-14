
public abstract class Goal 
{
    public string Name {get; set;}
    public string Type {get;}
    public int Points {get;}
    public bool IsComplete{ get; protected set;}

    public int Progress {get; protected set;}
    public int BonusPoints {get; protected set;}

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