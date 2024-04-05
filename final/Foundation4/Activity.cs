using System;

public class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public virtual double GetDistance()
    {
        //default
        return 0;
    }

    public virtual double GetSpeed()
    {
        //default
        return 0;
    }

    public virtual double GetPace()
    {
        //default
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_date.ToShortDateString()} ({_minutes} min)";
    }
}