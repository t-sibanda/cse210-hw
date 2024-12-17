using System;
using System.Collections.Generic;

public class ListingActivity : MindfulnessActivity
{
    private List<string> _prompts = new List<string>
    {
        "What are some skills you’ve developed recently?",
        "What are moments from today that made you smile?",
        "What are things or experiences you’re grateful for?",
        "Who are the people in your life who inspire you?",
        "What are things you love about your current environment?"
    };

    public ListingActivity()
        : base("Listing Activity", "This activity encourages you to focus on the positive aspects of your life by listing things that bring you joy or fulfillment.") { }

    protected override void PerformActivity(int duration)
    {
        Random random = new Random();
        Console.WriteLine($"\n{_prompts[random.Next(_prompts.Count)]}");
        Console.WriteLine("You have a few seconds to prepare...");
        ShowCountdown(5);

        Console.WriteLine("\nStart listing items:");
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items!");
    }
}
