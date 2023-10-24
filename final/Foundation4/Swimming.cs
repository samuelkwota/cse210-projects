
class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int lengthMinutes, int laps)
        : base(date, lengthMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 0.05; // 50 meters per lap
    }

    public override double GetSpeed()
    {
        return (laps * 0.05) / (lengthMinutes / 60.0); // Speed in km/h
    }

    public override string GetPace()
    {
        return (lengthMinutes / (laps * 0.05)).ToString("F1");
    }
}
