class ChecklistGoal : Goal
{
    private int TargetCount;

    public ChecklistGoal(string name, int value, int targetCount) : base(name, value)
    {
        TargetCount = targetCount;
    }

    public override void RecordEvent()
    {
        base.RecordEvent();
        if (CurrentProgress >= TargetCount)
            IsComplete = true;
    }

    public override string GetProgress()
    {
        return $"Completed {CurrentProgress}/{TargetCount} times";
    }

    public override string GetGoalType()
    {
        return "Checklist";
    }
}
