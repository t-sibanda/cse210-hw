using System;
class GuessMyNumber
{
    static void Main(string[] args)
    {
        int magicNumber = new Random().Next(1, 101);

        Console.WriteLine("What is the magic number? ");
        int guess = int.Parse(Console.ReadLine());

        int numberOfGuesses = 1;

        while (guess != magicNumber)
        {
            if (guess > magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Lower");
            }

            guess = int.Parse(Console.ReadLine());

            numberOfGuesses++;
        }

        if (guess == magicNumber)
        {
            Console.WriteLine("You guessed it! It took you {0} guesses.", numberOfGuesses);
        }

        Console.WriteLine("Would you like to play again? (y/n)");
        string playAgain = Console.ReadLine();

        if (playAgain == "y")
        {
            Main(new string [0]);
        }
    }
}