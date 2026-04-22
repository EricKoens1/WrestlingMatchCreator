using WrestlingCore;

Wrestler hogan = new Wrestler("Hulk Hogan", 70, 78, "Leg Drop",
    WeightClass.Heavyweight, ExperienceLevel.Legend);
Wrestler rock = new Wrestler("The Rock", 51, 77, "People's Elbow",
    WeightClass.Heavyweight, ExperienceLevel.SeasonedVet);
Wrestler stoneCold = new Wrestler("Stone Cold", 61, 74, "Stunner",
    WeightClass.Heavyweight, ExperienceLevel.Legend);

// Valid triple threat
TripleThreatMatch valid = new TripleThreatMatch(hogan, rock, stoneCold);
Console.WriteLine($"Summary: {valid.GetSummary()}");
Console.WriteLine($"Valid?   {valid.Validate()}");

// Invalid — Hogan listed twice
TripleThreatMatch invalid = new TripleThreatMatch(hogan, rock, hogan);
Console.WriteLine($"\nSummary: {invalid.GetSummary()}");
Console.WriteLine($"Valid?   {invalid.Validate()}");