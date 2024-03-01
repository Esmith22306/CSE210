using System;

public class Activity
{

//Attributes
private string _activityName;
private int _activityTime;



//Constructors
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



   public void Spinner()
    {


    }


public void DisplayEnding()
{

}








}