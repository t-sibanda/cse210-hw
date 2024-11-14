using System;
public class Program
{
    public static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Square numbers Program!");
    }
    public static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        return Console.ReadLine();
    }
    public static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }
    public static int SquareNumber(int number)
    {
        return number * number;
    }
    public static void DisplayResult(string name, int number)
    {
        Console.WriteLine("{0}, the square of your number is {1}", name, number);
    }
    public static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber = SquareNumber(number);
        DisplayResult(name, squaredNumber);
    }
}