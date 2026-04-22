using WrestlingCore;

Wrestler hogan = new Wrestler("Hulk Hogan", 70, 78, "Leg Drop",
    WeightClass.Heavyweight, ExperienceLevel.Legend);
Wrestler macho = new Wrestler("Macho Man", 58, 73, "Flying Elbow",
    WeightClass.Heavyweight, ExperienceLevel.Legend);
Wrestler rock = new Wrestler("The Rock", 51, 77, "People's Elbow",
    WeightClass.Heavyweight, ExperienceLevel.SeasonedVet);

// Valid team
Team megaPowers = new Team("The Mega Powers", hogan, macho);
Console.WriteLine($"Team: {megaPowers.TeamName}");
Console.WriteLine($"  - {megaPowers.Member1.Name}");
Console.WriteLine($"  - {megaPowers.Member2.Name}");

// Invalid team (same wrestler twice)
try
{
    Team invalid = new Team("Twin Hogans", hogan, hogan);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"\nCould not create team: {ex.Message}");
}