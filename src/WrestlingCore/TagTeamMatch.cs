namespace WrestlingCore;

public class TagTeamMatch : Match
{
    public Team Team1 { get; }
    public Team Team2 { get; }

    public TagTeamMatch(Team team1, Team team2)
    {
        this.Team1 = team1;
        this.Team2 = team2;
    }

    public override bool Validate()
    {
        return !Team2.Contains(Team1.Member1) && !Team2.Contains(Team1.Member2);
    }

    public override string GetSummary()
    {
        return $"Match: {Team1.TeamName} vs {Team2.TeamName}";
    }
}