using System.IO; 
using System;

public class JournalPrompt
{

    public static string[] _prompt = 
    {
        "What was a rose and a thorn from your day?", 
        "If you could change something about your day what would it be?", 
        "Describe your current mood?", 
        "What are your goals for tomorrow?", 
        "How would you rank this day compared to others?", 

    };

public List<string> _journalPrompt = new List<string>(_prompt);

public JournalPrompt()
{

}
public string GetPrompt()
{
    var random = new Random();
    int index = random.Next(_journalPrompt.Count);
    string Prompt = _prompt[index];
    return Prompt;

}


}