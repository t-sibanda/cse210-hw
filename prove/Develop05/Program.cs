using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("\nSelect an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new BreathingActivity().StartActivity();
                    break;
                case "2":
                    new ReflectionActivity().StartActivity();
                    break;
                case "3":
                    new ListingActivity().StartActivity();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    Thread.Sleep(2000);
                    break;
            }
        }
    }
}
