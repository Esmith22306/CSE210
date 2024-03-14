using System;

class Program
{
    static void Main(string[] args)
    {
            Journal journal = new Journal();
            JournalPrompt journalprompt = new JournalPrompt();
            journalEntry entry = new journalEntry();


            Console.Write("\nPlease select one of the following choices:\n");
            Console.Write("1. Write\n");
            Console.Write("2. Display\n");
            Console.Write("3. Load\n");
            Console.Write("4. Save\n");
            Console.Write("5. Quit\n");
            Console.Write("\nWhat would you like to do? ");
            string userInput = Console.ReadLine();
            int action = 0;
            action = int.Parse(userInput);

            while (action != 5)
            {
                //Write Entry 
                if (action == 1)
                {
                    string Prompt  = journalprompt.GetPrompt();
                    string date = GetDateTime();

                    
                    entry._dateTime = date;
                    entry._prompt = Prompt;

                    Console.Write($"{Prompt}\n");
                    Console.Write("--> ");
                    string userEntry = Console.ReadLine();
                    entry._Entry = userEntry;
                    journal._journal.Add(entry);
                    Console.Clear();

                }

                //Display
                else if (action == 2)
                {
                    journal.Display();
                }

                // Load file 
                else if (action == 3)
                {
                    journal.LoadJournalFile();
                }

                // Save file 
                else if (action == 4)
                {
                    journal.CreateJournalFile();
                }
                // Quit
                else 
                {
                Console.WriteLine("\nThank you for using the JournalProgram!\n");

                }


            }

            static string GetDateTime()
            {
                DateTime now = DateTime.Now;
                string currentDateTime = now.ToString("F");
                return currentDateTime;
            }
            




    }
}