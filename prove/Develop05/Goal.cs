class Goal
{
    public string Name { get; private set; }
    public int Value { get; private set; }
    public bool IsComplete { get; protected set; }
    public int CurrentProgress { get; protected set; }

    public Goal(string name, int value)
    {
        Name = name;
        Value = value;
        IsComplete = false;
        CurrentProgress = 0;
    }

    public virtual void RecordEvent()
    {
        CurrentProgress++;
    }

    public virtual string GetStatus()
    {
        return IsComplete ? "[X]" : "[ ]";
    }

    public virtual string GetProgress()
    {
        return string.Empty;
    }

    public virtual string GetGoalType()
    {
        return "Unknown";
    }
}
