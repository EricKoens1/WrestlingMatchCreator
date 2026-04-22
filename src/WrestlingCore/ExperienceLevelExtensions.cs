namespace WrestlingCore;

public static class ExperienceLevelExtensions
{
    public static string ToDisplay(this ExperienceLevel experienceLevel) => experienceLevel switch
    {
        ExperienceLevel.Trainee => "Trainee",
        ExperienceLevel.Rookie => "Rookie",
        ExperienceLevel.Veteran => "Veteran",
        ExperienceLevel.SeasonedVet => "Seasoned Vet",
        ExperienceLevel.Legend => "Legend",
        _ => experienceLevel.ToString()
    };
}