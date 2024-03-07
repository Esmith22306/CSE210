
using System;

public class BreathingActivity : Activity
{
    //attributes
    private string _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    //constructor
    public BreathingActivity(string activityName, int activityTime) : base(activityName, activityTime) 
    {

    }

    public void PerformBreathing()
    {
        DisplayGreeting();
        Console.WriteLine(_description);
        for (int i = 0; i < _activityTime; i++)
        {
            Console.WriteLine("Breathe in...");
            Spinner(3);
            Console.WriteLine("Now breathe out...");
            Spinner(3);
        }
        DisplayEnding();
    }


}