namespace WrestlingCore;

public abstract class Match
{
    public abstract bool Validate();
    public abstract string GetSummary();
}