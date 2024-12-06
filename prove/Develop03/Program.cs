using System;

class Program
{
    static void Main(string[] args)
    {
        // Create the scripture and its reference
        Reference reference = new Reference("John", 3, 16);
        string scriptureText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Scripture scripture = new Scripture(reference, scriptureText);

        // Display initial scripture
        Console.Clear();
        scripture.Display();
        Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");

        // Loop until the scripture is fully hidden or the user quits
        while (true)
        {
            string input = Console.ReadLine()?.Trim().ToLower();

            if (input == "quit")
            {
                Console.WriteLine("Thank you for using the Scripture Memorizer!");
                break;
            }

            scripture.HideRandomWord();
            Console.Clear();
            scripture.Display();

            if (scripture.IsComplete())
            {
                Console.WriteLine("All words are hidden. Good job!");
                break;
            }
        }
    }
}

