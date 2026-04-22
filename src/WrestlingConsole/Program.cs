using WrestlingCore;

Wrestler hogan = new Wrestler("Hulk Hogan", 70, 78, "Leg Drop",
    WeightClass.Heavyweight, ExperienceLevel.Legend);
Wrestler rock = new Wrestler("The Rock", 51, 77, "People's Elbow",
    WeightClass.Heavyweight, ExperienceLevel.SeasonedVet);

// Valid 1v1
NormalMatch main = new NormalMatch(hogan, rock);
Console.WriteLine($"Summary: {main.GetSummary()}");
Console.WriteLine($"Valid?   {main.Validate()}");

// Invalid (same wrestler twice — permitted at construction, caught by Validate)
NormalMatch bogus = new NormalMatch(hogan, hogan);
Console.WriteLine($"\nSummary: {bogus.GetSummary()}");
Console.WriteLine($"Valid?   {bogus.Validate()}");

// Polymorphism preview: treat the NormalMatch as a generic Match
Match asMatch = main;
Console.WriteLine($"\nAs Match: {asMatch.GetSummary()}");