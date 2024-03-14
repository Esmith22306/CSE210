using System;

public class Scripture
{

    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(string book, int chapter, int verse, string text)
    {
        _reference = new Reference(book, chapter, verse);
        _words = new List<Word>();
        _random = new Random();


        string[] splitText = text.Split(' ');
        foreach (string word in splitText)
            {
                _words.Add(new Word(word));
            }
    }


    public void Display()
        {
            Console.WriteLine($"{_reference}:");
            foreach (Word word in _words)
            {
                if (word.IsHidden())
                {
                    Console.Write(new string('_', word.GetWord().Length) + " ");
                }
                else
                {
                    Console.Write(word.GetWord() + " ");
                }
            }
        }

    public void HideWords()
    {
        int wordsToHide = 3;
        while (wordsToHide > 0)
        {
            int index = _random.Next(_words.Count);
            if(!_words[index].IsHidden())
            {
                _words[index].HideWord();
                wordsToHide--;
            }
        }
    }

    public bool AllHidden()
    {
        foreach (Word word in _words)
        {
            if(!word.IsHidden())
            return false;
        }
        return true;
    }
}