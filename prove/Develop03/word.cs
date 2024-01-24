using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _isHidden = true;
        _text = new string('_',_text.Length);
        
    }
    public void Show()
    {
        _isHidden = false;
        _text = _text.Replace(_text,_text);
    }

    public bool IsHidden()
    {
       return _isHidden;
    }

    public string GetDisplayText()
    {
        return _text;
    }
}