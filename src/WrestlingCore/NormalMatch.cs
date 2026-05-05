namespace WrestlingCore;

public class NormalMatch : Match
{
    public Wrestler Wrestler1 { get; }
    public Wrestler Wrestler2 { get; }

    public NormalMatch(string matchName, Wrestler wrestler1, Wrestler wrestler2)
        : base(matchName)
    {
        if (string.Equals(wrestler1.Name, wrestler2.Name, StringComparison.OrdinalIgnoreCase))
        {
            throw new ArgumentException("Same wrestler cannot be used twice in the same match.");
        }
        this.Wrestler1 = wrestler1;
        this.Wrestler2 = wrestler2;
    }

    public override bool Validate()
    {
        return true;
    }

    public override string GetSummary()
    {
        return $"{MatchName}: {Wrestler1.Name} vs {Wrestler2.Name}";
    }
}