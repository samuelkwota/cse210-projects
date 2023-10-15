class EternalGoal : Goal
{
    public EternalGoal(string name, int value) : base(name, value) { }

    public override string GetGoalType()
    {
        return "Eternal";
    }
}
