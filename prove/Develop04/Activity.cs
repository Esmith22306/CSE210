using System;

public class Activity
{

    //Attributes
    private string _activityName;
    protected int _activityTime; // Changed accessibility to protected

    //Constructor
    public Activity(string activityName, int activityTime)
    {
        _activityName = activityName;
        _activityTime = activityTime;
    }


    public void DisplayGreeting()
    {
        Console.WriteLine($"Welcome to the {_activityName} Activity\n");
    }

    public int GetActivityTime()
    {
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        int userSeconds = Int32.Parse(Console.ReadLine());
        _activityTime = userSeconds;
        return userSeconds;
    }



    public void Spinner(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }




    public void DisplayEnding()
    {
        Console.WriteLine($"You have completed the {_activityName} activity for {_activityTime} seconds.");
        Console.WriteLine("Well done!");
    }

}