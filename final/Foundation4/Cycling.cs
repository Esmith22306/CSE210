public class Cycling : Activity 
{
    private double _speed;

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
       _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Speed: {_speed:F2} kph, Pace: {GetPace():F2} min/km";
    }    
}