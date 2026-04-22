using WrestlingCore;

Wrestler hogan = new Wrestler("Hulk Hogan", 70, 78, "Leg Drop",
    WeightClass.Heavyweight, ExperienceLevel.Legend);
Wrestler macho = new Wrestler("Macho Man", 58, 73, "Flying Elbow",
    WeightClass.Heavyweight, ExperienceLevel.Legend);
Wrestler rock = new Wrestler("The Rock", 51, 77, "People's Elbow",
    WeightClass.Heavyweight, ExperienceLevel.SeasonedVet);
Wrestler stoneCold = new Wrestler("Stone Cold", 61, 74, "Stunner",
    WeightClass.Heavyweight, ExperienceLevel.Legend);

Team megaPowers = new Team("The Mega Powers", hogan, macho);
Team brothersInArms = new Team("Brothers in Arms", rock, stoneCold);
Team overlapTeam = new Team("Overlap Team", macho, rock);  // Macho is ALSO in Mega Powers

// Valid tag match — no wrestler on both sides
TagTeamMatch validTag = new TagTeamMatch(megaPowers, brothersInArms);
Console.WriteLine($"Summary: {validTag.GetSummary()}");
Console.WriteLine($"Valid?   {validTag.Validate()}");

// Invalid — Macho is on both teams
TagTeamMatch overlappingTag = new TagTeamMatch(megaPowers, overlapTeam);
Console.WriteLine($"\nSummary: {overlappingTag.GetSummary()}");
Console.WriteLine($"Valid?   {overlappingTag.Validate()}");