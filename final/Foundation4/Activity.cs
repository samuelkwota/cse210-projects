
class Activity
{
    private DateTime date;
    public int lengthMinutes;

    public Activity(DateTime date, int lengthMinutes)
    {
        this.date = date;
        this.lengthMinutes = lengthMinutes;
    }

    public virtual double GetDistance()
    {
        return 0.0;
    }

    public virtual double GetSpeed()
    {
        return 0.0;
    }

    public virtual string GetPace()
    {
        return "N/A";
    }

    public string GetSummary()
    {
        return $"{date:dd MMM yyyy} {GetType().Name} ({lengthMinutes} min) - Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace()} min per mile";
    }
}