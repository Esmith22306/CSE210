using System.IO; 
using System;

public class journalEntry
{
    public string _dateTime = "";

    public string _prompt = "";

    public string _Entry = "";


    public journalEntry()
    {

    }

    public void Display()
    {
        Console.WriteLine($"Date: {_dateTime}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_Entry}");
    }
}