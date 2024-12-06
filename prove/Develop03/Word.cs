using System;

public class Word
{
    private readonly string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public bool IsHidden
    {
        get { return _isHidden; }
        set { _isHidden = value; }
    }

    public string Display()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}
