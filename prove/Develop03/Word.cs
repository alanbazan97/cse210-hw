using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false; // Initialize as not hidden
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetRenderedText()
    {
        if (_isHidden)
        {
            return "_____"; // Render hidden words as underscores
        }
        else
        {
            return _text;
        }
    }
}
