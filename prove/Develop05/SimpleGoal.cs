class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value) : base(name, value) { }

    public override void RecordEvent()
    {
        base.RecordEvent();
        IsComplete = true;
    }

    public override string GetGoalType()
    {
        return "Simple";
    }
}
