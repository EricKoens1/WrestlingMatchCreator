namespace WrestlingCore;

public class Roster
{
    private List<Wrestler> wrestlers;

    public Roster()
    {
        wrestlers = new List<Wrestler>();
    }

    public IReadOnlyList<Wrestler> Wrestlers => wrestlers;

    public void AddWrestler(Wrestler wrestler)
    {
        foreach (Wrestler existing in wrestlers)
        {
            if (string.Equals(existing.Name, wrestler.Name, StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException(
                    $"A wrestler named '{wrestler.Name}' already exists in the roster.",
                    nameof(wrestler));
            }
        }
        wrestlers.Add(wrestler);
    }
}