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
        Console.Write("Enter file name? ");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";
        if (!File.Exists(_userFileName))
        {
            File.CreateText(_userFileName);
            Console.Write($"\n->->-> {_userFileName} has been created! <-<-<-\n");
            Console.Write("->->->Your journal entries have been saved. <-<-<-\n");
            SaveJournalFile(_userFileName);
        }
        else
        {
            Console.Write($"\n->->-> {_userFileName} already exits. <-<-<-\n");
            Console.Write("->->->Your journal entries have been added. <-<-<-\n");
            SaveJournalFile(_userFileName);
        }
    }

    public void SaveJournalFile(string _userFileName)
    {
        using (StreamWriter outputFile = new StreamWriter(_userFileName))
        {
            foreach (journalEntry entry in _journal)
            {
                outputFile.WriteLine($"{entry._dateTime};{entry._prompt}; {entry._Entry}");
            }
        }
    }


    public void LoadJournalFile()
    {
        Console.Write("What is your file name? ");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";
        if (File.Exists(_userFileName))
        {
            List<string> readText = File.ReadAllLines(_userFileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
            foreach (string line in readText)
            {
                string[] entries = line.Split("; ");
                journalEntry entry = new journalEntry();
                entry._dateTime = entries[1];
                entry._prompt = entries[2];
                entry._Entry = entries[3];
                _journal.Add(entry);
            }
        }
    }
}