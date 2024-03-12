using System.IO; 
using System;

public class Journal
{
    // variables
    public List<journalEntry> _journal = new List<journalEntry>();
    string _userFileName;

    public Journal ()
    {

    }

    public void AddEntry(string dateTime, string prompt, string entry)
    {
        journalEntry newEntry = new journalEntry(dateTime, prompt, entry);
        _journal.Add(newEntry);
    }

    public void Display()
    {
       Console.WriteLine("\n->->->->->-> Journal Entries <-<-<-<-<-<-");       
        foreach (journalEntry entry in _journal)
        {
            entry.Display();

        }
        Console.WriteLine("->->->->->-> End <-<-<-<-<-<-");
    }


    public void CreateJournalFile()
    {
        Console.Write("Enter file name: ");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";

        using (StreamWriter outputFile = new StreamWriter(_userFileName))
        {
            foreach (journalEntry entry in _journal)
            {
                outputFile.WriteLine($"{entry.DateTime};{entry.Prompt};{entry.Entry}");
            }
        }

        Console.WriteLine($"\n{_userFileName} has been created!");
    }


    public void LoadJournalFile()
    {
        Console.Write("Enter file name: ");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";

        if (File.Exists(_userFileName))
        {
            _journal.Clear(); // Clear existing entries before loading

            List<string> readText = File.ReadAllLines(_userFileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
            foreach (string line in readText)
            {
                string[] entries = line.Split(';');
                if (entries.Length >= 3)
                {
                    _journal.Add(new journalEntry(entries[0], entries[1], entries[2]));
                }
            }
            Console.WriteLine("\nJournal entries loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}