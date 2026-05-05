using System.Text;

namespace WrestlingCore;

public class MatchCard
{
    public string EventName { get; set; }
    private List<Match> matches;

    public MatchCard(string eventName)
    {
        this.EventName = eventName;
        this.matches = new List<Match>();
    }

    public IReadOnlyList<Match> Matches => matches;

    public void AddMatch(Match match)
    {
        matches.Add(match);
    }

    public string GetCardSummary()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{EventName} - Match Card");
        sb.AppendLine(new string('=', 40));

        for (int i = 0; i < matches.Count; i++)
        {
            Match m = matches[i];
            sb.AppendLine($"{i + 1}. {m.GetSummary()}");
        }
        return sb.ToString();
    }
}