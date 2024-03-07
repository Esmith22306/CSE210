
using System;

public class ListingActivity : Activity
{


    //Attributes

    private string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    //constructor
    public ListingActivity(string activityName, int activityTime) : base(activityName, activityTime) 
    {

    }

    //methods 
    public void PerformListing()
    {
        DisplayGreeting();
        Console.WriteLine(_description);
        
        Console.WriteLine("Start listing... ");
        Spinner(3);
        Console.WriteLine("Enter items:");

        int itemsCount = 0;
        for (int i = 0; i < _activityTime; i++)
        {
            Console.WriteLine($"Item {++itemsCount}: {Console.ReadLine()}");
        }

        Console.WriteLine($"You listed {itemsCount} items.");
        DisplayEnding();
    }

}