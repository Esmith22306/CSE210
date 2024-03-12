using System;

class Program
{
    static void Main(string[] args)
    {
            Journal journal = new Journal();
            JournalPrompt journalprompt = new JournalPrompt();
        while (true)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("\nWhat would you like to do? ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int action))
            {
                switch (action)
                {
                    case 1:
                        string prompt = journalprompt.GetPrompt();
                        string date = GetDateTime();

                        Console.WriteLine(prompt);
                        Console.Write("--> ");
                        string userEntry = Console.ReadLine();

                        journal.AddEntry(date, prompt, userEntry);
                        break;

                    case 2:
                        journal.Display();
                        break;

                    case 3:
                        journal.LoadJournalFile();
                        break;

                    case 4:
                        journal.CreateJournalFile();
                        break;

                    case 5:
                        Console.WriteLine("\nThank you for using the JournalProgram!\n");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

    static string GetDateTime()
    {
        return DateTime.Now.ToString("F");
    }



}
