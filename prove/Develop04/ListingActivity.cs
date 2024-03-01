
using System;

public class ListingActivity : Activity
{


    //Attributes

    private List <string> _promptList = new List<string>
    {

    };

    private List<string> _userList = new List<string>();
    private string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";


    //constructor
    public ListingActivity(string activityName, int activityTime) : base(activityName, activityTime)
    {

    }
    //methods 
    public void DisplayPrompt()
    {

    }

    public void DisplayCount()
    {

    }

}