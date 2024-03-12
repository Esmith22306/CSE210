using System.IO; 
using System;

public class journalEntry
{
    public string DateTime = "";

    public string Prompt = "";

    public string Entry = "";


    public journalEntry(string dateTime, string prompt, string entry)
    {
        DateTime = dateTime;
        Prompt = prompt;
        Entry = entry;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {DateTime}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Entry: {Entry}");
    }

}