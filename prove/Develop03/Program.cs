using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a Scripture instance
        Scripture scripture = new Scripture(new Reference("John", 3, 16, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        // Display the full scripture
        Console.WriteLine(scripture.Reference.GetReferenceString());
        Console.WriteLine(scripture.Text);

        Console.WriteLine("\nPress Enter to continue or 'quit' to exit.");

        while (true)
        {
            Console.ReadLine();


            // Randomly hide a word
            Random random = new Random();
            List<Word> words = scripture.GetWords();
            int index = random.Next(words.Count);
            words[index].IsHidden = true;

            // Clear the console and display the updated scripture
            Console.Clear();
            Console.WriteLine(scripture.Reference.GetReferenceString());
            foreach (Word word in words)
            {
                Console.Write(word.Display() + " ");
            }
            Console.WriteLine();

            if (words.All(word => word.IsHidden))
            {
                Console.WriteLine("All words are hidden. Good job!");
                break;
            }
        }
    }
}