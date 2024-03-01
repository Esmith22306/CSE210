
using System;

public class BreathingActivity : Activity
{
    //attributes
    private string _message1 = "Breathe in...";
    private string _message2 = "Now breathe out...";
    private string _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    //constructor
    public BreathingActivity(string activityName, int activityTime) : base(activityName, activityTime)
    {
        
    }


}