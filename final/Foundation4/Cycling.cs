
class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int lengthMinutes, double speed)
        : base(date, lengthMinutes)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetDistance()
    {
        return (speed * lengthMinutes) / 60.0;
    }

    public override string GetPace()
    {
        return (60.0 / speed).ToString("F1");
    }
}