namespace WrestlingCore;

public class Team
{
    public string TeamName { get; }
    public Wrestler Member1 { get; }
    public Wrestler Member2 { get; }

    public Team(string teamName, Wrestler member1, Wrestler member2)
    {
        if (string.Equals(member1.Name, member2.Name, StringComparison.OrdinalIgnoreCase))
        {
            throw new ArgumentException(
                $"A team cannot have duplicate members: '{member1.Name}' and '{member2.Name}' are the same wrestler.");
        }
        this.TeamName = teamName;
        this.Member1 = member1;
        this.Member2 = member2;
    }
}