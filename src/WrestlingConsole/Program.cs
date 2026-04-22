using WrestlingCore;

Roster roster = new Roster();

roster.AddWrestler(new Wrestler("Hulk Hogan", 70, 78, "Leg Drop",
    WeightClass.Heavyweight, ExperienceLevel.Legend));

roster.AddWrestler(new Wrestler("The Rock", 51, 77, "People's Elbow",
    WeightClass.Heavyweight, ExperienceLevel.SeasonedVet));

roster.AddWrestler(new Wrestler("Rey Mysterio", 49, 66, "619",
    WeightClass.Cruiserweight, ExperienceLevel.Legend));

roster.AddWrestler(new Wrestler("Yokozuna", 40, 72, "Banzai Drop",
    WeightClass.SuperHeavyweight, ExperienceLevel.Veteran));

Console.WriteLine($"Roster ({roster.Wrestlers.Count} wrestlers):");
foreach (Wrestler w in roster.Wrestlers)
{
    Console.WriteLine($"  - {w.Name} ({w.WeightClass.ToDisplay()}, {w.ExperienceLevel.ToDisplay()})");
}