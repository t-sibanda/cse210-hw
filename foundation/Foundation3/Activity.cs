using System;

abstract class Activity
{
    private DateTime date;
    private int minutes;
    public Activity(DateTime date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }
    public int GetMinutes() => minutes;
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")} {this.GetType().Name} ({minutes} min): " +
               $"Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace {GetPace():0.00} min per km";
    }
}
