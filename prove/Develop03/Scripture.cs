using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private readonly Reference _reference;
    private readonly List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word.Trim(' ', ',', '.'))).ToList();
    }

    public void Display()
    {
        Console.WriteLine(_reference.GetReferenceString());
        foreach (Word word in _words)
        {
            Console.Write(word.Display() + " ");
        }
        Console.WriteLine();
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        var availableWords = _words.Where(word => !word.IsHidden).ToList();

        if (availableWords.Any())
        {
            int index = random.Next(availableWords.Count);
            availableWords[index].IsHidden = true;
        }
    }

    public bool IsComplete()
    {
        return _words.All(word => word.IsHidden);
    }
}
