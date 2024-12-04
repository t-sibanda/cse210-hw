public class Scripture
{
    public Reference Reference { get; }
    public string Text { get; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Text = text;
    }

    public List<Word> GetWords()
    {
        return Text.Split(' ').Select(word => new Word(word)).ToList();
    }
}