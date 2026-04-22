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
        wrestlers.Add(wrestler);
    }
}