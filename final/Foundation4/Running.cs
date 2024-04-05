using System;

public class Running : Activity 
{
    private double _distance;

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
       _distance = distance;
    }

    //Overide methods
    public override double GetDistance()
    {
        
        return _distance;
    }

    public override double GetSpeed()
    {
        
        return _distance / (minutes / 60.0);
    }

    public override double GetPace()
    {
        return minutes / _distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {_distance:F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min/mile";
    }
}