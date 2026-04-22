namespace WrestlingCore;

public class Wrestler : Person
{
    public string FinishingMove { get; set; }

    public Wrestler(string name, int age, int height, string finishingMove) 
        : base(name, age, height)
    {
        FinishingMove = finishingMove;
    }
}