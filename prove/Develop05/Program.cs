using System;

class Program
{
    static void Main(string[] args)
    {
    Console.WriteLine("Welcome to Eternal Quest!");
    Console.WriteLine("Enter your username: ");
    string username = Console.ReadLine();

    User user = new User(username);

    user.SetGoalsManually();

      while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Record Completed Event");
            Console.WriteLine("2. View Goals and Scores");
            Console.WriteLine("3. Save Data");
            Console.WriteLine("4. Load Data");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Choose an option:");

            int option;
            if (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Invalid option. Please enter a number.");
                continue;
            }

            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter the name of the goal you completed:");
                    string goalName = Console.ReadLine();
                    user.RecordEvent(goalName);
                    break;
                case 2:
                    user.DisplayGoals();
                    break;
                case 3:
                    Console.WriteLine("Enter the filename to save data:");
                    string saveFileName = Console.ReadLine();
                    user.SaveData(saveFileName);
                    Console.WriteLine("Data saved successfully.");
                    break;
                case 4:
                    Console.WriteLine("Enter the filename to load data:");
                    string loadFileName = Console.ReadLine();
                    user.LoadData(loadFileName);
                    Console.WriteLine("Data loaded successfully.");
                    break;
                case 5:
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please choose a number from the menu.");
                    break;
            }
        }

    }


}
