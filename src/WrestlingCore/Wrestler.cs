namespace WrestlingCore;

public class Wrestler : Person
{
    public string FinishingMove { get; set; }
    public WeightClass WeightClass { get; set; }
    public ExperienceLevel ExperienceLevel { get; set; }

    public Wrestler(string name, int age, int height, 
    string finishingMove, WeightClass weightClass, ExperienceLevel experienceLevel) 
        : base(name, age, height)
    {
        this.FinishingMove = finishingMove;
        this.WeightClass = weightClass;
        this.ExperienceLevel = experienceLevel;
    }
}