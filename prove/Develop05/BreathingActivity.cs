public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() 
        : base("Breathing Activity", "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breathing.") { }
    protected override void PerformActivity(int duration)
    {
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountdown(4);
            Console.WriteLine();
        }
    }
}
