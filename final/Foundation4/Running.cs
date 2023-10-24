
class Running : Activity
{
    private double distance;

    public Running(DateTime date, int lengthMinutes, double distance)
        : base(date, lengthMinutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / (lengthMinutes / 60.0);
    }

    public override string GetPace()
    {
        return (lengthMinutes / distance).ToString("F1");
    }
}
