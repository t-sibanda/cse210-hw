using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2024, 12, 18), 30, 8.0),
            new Cycling(new DateTime(2024, 12, 18), 60, 33.0),
            new Swimming(new DateTime(2024, 12, 18), 45, 45)
        };
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
