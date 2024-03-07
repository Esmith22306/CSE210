using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Ext ");          
            int choice = int.Parse(Console.ReadLine());

            Activity activity = null;

            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity("Breathing", 0);
                    activity.GetActivityTime();
                    ((BreathingActivity)activity).PerformBreathing();
                    break;
                case 2:
                    activity = new ReflectingAcitivty ("Reflection", 0);
                    activity.GetActivityTime();
                    ((ReflectingAcitivty )activity).PerformReflection();
                    break;
                case 3:
                    activity = new ListingActivity("Listing", 0);
                    activity.GetActivityTime();
                    ((ListingActivity)activity).PerformListing();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            
        }
        
    }
}