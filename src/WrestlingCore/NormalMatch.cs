namespace WrestlingCore;

public class NormalMatch : Match
{
    public Wrestler Wrestler1 { get; }
    public Wrestler Wrestler2 { get; }

    public NormalMatch(Wrestler wrestler1, Wrestler wrestler2)
    {
        this.Wrestler1 = wrestler1;
        this.Wrestler2 = wrestler2;
    }

    public override bool Validate()
    {
        return Wrestler1 != null && Wrestler2 != null && Wrestler1 != Wrestler2;
    }

    public override string GetSummary()
    {
        return $"Match: {Wrestler1.Name} vs {Wrestler2.Name}";
    }
}