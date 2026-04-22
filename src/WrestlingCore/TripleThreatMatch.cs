namespace WrestlingCore;

public class TripleThreatMatch : Match
{
    public Wrestler Wrestler1 { get; }
    public Wrestler Wrestler2 { get; }
    public Wrestler Wrestler3 { get; }

    public TripleThreatMatch(Wrestler wrestler1, Wrestler wrestler2, Wrestler wrestler3)
    {
        this.Wrestler1 = wrestler1;
        this.Wrestler2 = wrestler2;
        this.Wrestler3 = wrestler3;
    }

    public override bool Validate()
    {
        return !string.Equals(Wrestler1.Name, Wrestler2.Name, StringComparison.OrdinalIgnoreCase) &&
               !string.Equals(Wrestler1.Name, Wrestler3.Name, StringComparison.OrdinalIgnoreCase) &&
               !string.Equals(Wrestler2.Name, Wrestler3.Name, StringComparison.OrdinalIgnoreCase);
    }

    public override string GetSummary()
    {
        return $"Match: {Wrestler1.Name} vs. {Wrestler2.Name} vs. {Wrestler3.Name}";
    }

}