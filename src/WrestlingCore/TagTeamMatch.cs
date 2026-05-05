namespace WrestlingCore;

public class TagTeamMatch : Match
{
    public Team Team1 { get; }
    public Team Team2 { get; }

    public TagTeamMatch(string matchName, Team team1, Team team2)
        : base(matchName)
    {
        if (team2.Contains(team1.Member1) || team2.Contains(team1.Member2))
        {
            throw new ArgumentException("Same wrestler cannot be used twice in the same match.");
        }
        this.Team1 = team1;
        this.Team2 = team2;
    }

    public override bool Validate()
    {
        return true;
    }

    public override string GetSummary()
    {
        return $"{MatchName}: {Team1.TeamName} vs {Team2.TeamName}";
    }
}