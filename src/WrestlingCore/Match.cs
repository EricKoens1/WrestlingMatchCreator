namespace WrestlingCore;

public abstract class Match
{
    public string MatchName { get; }

    protected Match(string matchName)
    {
        this.MatchName = matchName;
    }

    public abstract bool Validate();

    public abstract string GetSummary();
}