using System;
using System.Collections.Generic;

public class ReflectionActivity : MindfulnessActivity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you overcame a significant challenge.",
        "Think of a time when you made a positive impact on someone's life.",
        "Think of a moment when you felt proud of yourself.",
        "Think of a time when you learned something valuable from a difficult experience."
    };

    private List<string> _questions = new List<string>
    {
        "What emotions did you feel during this experience?",
        "What motivated you to push through?",
        "How did this experience change your perspective?",
        "What support or resources helped you during this time?",
        "What lessons can you carry forward from this experience?",
        "What strengths did you discover about yourself?",
        "If you could go back, would you change anything about how you handled it?",
        "How can you apply what you learned to future challenges?"
    };

    public ReflectionActivity()
        : base("Reflection Activity", "This activity helps you explore meaningful moments in your life, uncover lessons, and grow from your past experiences.") { }

    protected override void PerformActivity(int duration)
    {
        Random random = new Random();
        Console.WriteLine($"\n{_prompts[random.Next(_prompts.Count)]}\n");
        ShowSpinner(5);

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"> {_questions[random.Next(_questions.Count)]}");
            ShowSpinner(5);
        }
    }
}
