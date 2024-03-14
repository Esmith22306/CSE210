using System;

public class Word
{

    private string _word;
    private bool _isHidden;
    

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public string GetWord ()
    {
        return _word;
    }

    public bool CheckIfHidden()
    {
        return _isHidden;
    }
    public void HideWord()
    {
        _isHidden = true;
    }

    public bool AllHidden()
    {
        return true;
    }




}