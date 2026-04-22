using WrestlingCore;

Roster roster = new Roster();

roster.AddWrestler(new Wrestler("Hulk Hogan", 70, 78, "Leg Drop",
    WeightClass.Heavyweight, ExperienceLevel.Legend));

roster.AddWrestler(new Wrestler("The Rock", 51, 77, "People's Elbow",
    WeightClass.Heavyweight, ExperienceLevel.SeasonedVet));

// Try to add a duplicate (different capitalization) — should be rejected
try
{
    roster.AddWrestler(new Wrestler("hulk hogan", 65, 78, "Leg Drop 2",
        WeightClass.Heavyweight, ExperienceLevel.Legend));
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Could not add duplicate: {ex.Message}");
}

Console.WriteLine($"\nRoster ({roster.Wrestlers.Count} wrestlers):");
foreach (Wrestler w in roster.Wrestlers)
{
    Console.WriteLine($"  - {w.Name} ({w.WeightClass.ToDisplay()}, {w.ExperienceLevel.ToDisplay()})");
}