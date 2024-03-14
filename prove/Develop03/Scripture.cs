using System;

public class Scripture
{

    private Reference _reference;
    private List<Word> _words;

    public Scripture(string book, int chapter, int verse, string text)
    {
        _reference = new Reference(book, chapter, verse);
        _words = new List<Word>();


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
                if (word.CheckIfHidden())
                {
                    Console.Write(new string('_', word.GetWord().Length) + " ");
                }
                else
                {
                    Console.Write(word.GetWord() + " ");
                }
            }
        }





}