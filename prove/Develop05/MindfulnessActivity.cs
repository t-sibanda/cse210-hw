using System;
using System.Threading;

public abstract class MindfulnessActivity
{
    private string _name;
    private string _description;

    public MindfulnessActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine($"\n{_description}");
        Console.Write("\nHow long would you like to do this activity (in seconds)? ");
        int duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPrepare to begin...");
        ShowSpinner(3);

        PerformActivity(duration);

        EndActivity(duration);
    }
    protected abstract void PerformActivity(int duration);

    private void EndActivity(int duration)
    {
        Console.WriteLine("\nGood job! You have completed the activity.");
        Console.WriteLine($"You spent {duration} seconds on the {_name}.");
        ShowSpinner(3);
    }
    protected void ShowSpinner(int durationInSeconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(durationInSeconds);
        while (DateTime.Now < endTime)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b/");
            Thread.Sleep(250);
            Console.Write("\b \b-");
            Thread.Sleep(250);
            Console.Write("\b \b\\");
            Thread.Sleep(250);
        }
        Console.Write("\b \b"); // Clear the last spinner
    }
    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
