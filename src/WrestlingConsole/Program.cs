using WrestlingCore;

// Create Wrestlers
Wrestler hulkHogan = new Wrestler("Hulk Hogan", 70, 78, "Leg Drop",
    WeightClass.Heavyweight, ExperienceLevel.Legend);
Wrestler machoMan = new Wrestler("Macho Man", 58, 73, "Flying Elbow",
    WeightClass.Heavyweight, ExperienceLevel.Legend);
Wrestler theRock = new Wrestler("The Rock", 51, 77, "People's Elbow",
    WeightClass.Heavyweight, ExperienceLevel.SeasonedVet);
Wrestler stoneCold = new Wrestler("Stone Cold", 61, 74, "Stunner",
    WeightClass.Heavyweight, ExperienceLevel.Legend);
Wrestler undertaker = new Wrestler("The Undertaker", 60, 82, "Tombstone",
    WeightClass.Heavyweight, ExperienceLevel.Legend);
Wrestler kane = new Wrestler("Kane", 58, 80, "Chokeslam",
    WeightClass.Heavyweight, ExperienceLevel.Legend);
Wrestler reyMysterio = new Wrestler("Rey Mysterio", 49, 66, "619",
    WeightClass.Cruiserweight, ExperienceLevel.Legend);
Wrestler shawnMichaels = new Wrestler("Shawn Michaels", 35, 72, "Sweet Chin Music",
    WeightClass.LightHeavyweight, ExperienceLevel.SeasonedVet);
Wrestler tripleH = new Wrestler("Triple H", 33, 71, "The Pedigree",
    WeightClass.Heavyweight, ExperienceLevel.Veteran);
Wrestler joeHendry = new Wrestler("Joe Hendry", 28, 68, "Standing Ovation",
    WeightClass.Heavyweight, ExperienceLevel.Rookie);
Wrestler erickThorsson = new Wrestler("Erick Thorsson", 20, 74, "Thor's Hammer",
    WeightClass.LightHeavyweight, ExperienceLevel.Trainee);
Wrestler yokozuna = new Wrestler("Yokozuna", 39, 65, "Bonzai Drop",
    WeightClass.SuperHeavyweight, ExperienceLevel.Legend);
Wrestler roadWarriorAnimal = new Wrestler("Road Warrior Animal", 50, 68, "Doomsday Device",
    WeightClass.SuperHeavyweight, ExperienceLevel.Legend);
Wrestler roadWarriorHawk = new Wrestler("Road Warrior Hawk", 50, 72, "Doomsday Device",
    WeightClass.SuperHeavyweight, ExperienceLevel.Legend);
Wrestler bretHart = new Wrestler("Bret Hart", 35, 69, "Sharpshooter",
    WeightClass.LightHeavyweight, ExperienceLevel.Veteran);

// Build Roster
Roster roster = new Roster();
roster.AddWrestler(hulkHogan);
roster.AddWrestler(machoMan);
roster.AddWrestler(theRock);
roster.AddWrestler(stoneCold);
roster.AddWrestler(undertaker);
roster.AddWrestler(kane);
roster.AddWrestler(reyMysterio);
roster.AddWrestler(shawnMichaels);
roster.AddWrestler(tripleH);
roster.AddWrestler(joeHendry);
roster.AddWrestler(erickThorsson);
roster.AddWrestler(yokozuna);
roster.AddWrestler(roadWarriorAnimal);
roster.AddWrestler(roadWarriorHawk);
roster.AddWrestler(bretHart);

// try adding a duplicate wrestler to the roster
try
{
    roster.AddWrestler(hulkHogan);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"[Roster validation working] {ex.Message}\n");
}

// Display Roster
Console.WriteLine($"Roster: {roster.Wrestlers.Count} wrestlers loaded.");
foreach (Wrestler w in roster.Wrestlers)
{
    Console.WriteLine($"  - {w.Name} ({w.WeightClass.ToDisplay()}, {w.ExperienceLevel.ToDisplay()})");
}

// Teams
Team megaPowers = new Team("The Mega Powers", hulkHogan, machoMan);
Team brothersOfDestruction = new Team("Brothers of Destruction", undertaker, kane);
Team dGenerationX = new Team("D-Generation X", shawnMichaels, tripleH);
Team twoManPowerTrip = new Team("Two Man Power Trip", stoneCold, tripleH);
Team roadWarriors = new Team("The Road Warriors", roadWarriorAnimal, roadWarriorHawk);

// try adding a team with the same wrestler twice
try
{
    Team brokenTeam = new Team("Bad Team", hulkHogan, hulkHogan);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"\n[Team validation working] {ex.Message}");
}

// Display teams
List<Team> teams = new List<Team> { megaPowers, brothersOfDestruction, dGenerationX, twoManPowerTrip, roadWarriors };
Console.WriteLine($"\nTeams: {teams.Count} teams formed.");
foreach (Team t in teams)
{
    Console.WriteLine($"  - {t.TeamName}: {t.Member1.Name} & {t.Member2.Name}");
}

// Matches (all three types!)
TagTeamMatch opener = new TagTeamMatch("Tag Team Exhibition", megaPowers, roadWarriors);
TripleThreatMatch intercontinentalChampionship = new TripleThreatMatch("Intercontinental Championship", joeHendry, erickThorsson, reyMysterio);
TagTeamMatch tagTeamChampionship = new TagTeamMatch("Tag Team Championship", dGenerationX, brothersOfDestruction);
NormalMatch worldChampionship = new NormalMatch("World Championship", bretHart, yokozuna);
NormalMatch mainEvent = new NormalMatch("Main Event", stoneCold, theRock);

// try adding an invalid normal match
try
{
    NormalMatch invalidNormalMatch = new NormalMatch("Invalid Normal Match", hulkHogan, hulkHogan);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"\n[Normal Match creation validation working] {ex.Message}");
}

// try adding an invalid tag team match
try
{
    TagTeamMatch invalidTagTeamMatch = new TagTeamMatch("Invalid Tag Team Match", dGenerationX, twoManPowerTrip);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"\n[Tag Team Match creation validation working] {ex.Message}");
}

// try adding an invalid triple threat match
try
{
    TripleThreatMatch invalidTripleThreatMatch = new TripleThreatMatch("Invalid Triple Threat Match", hulkHogan, hulkHogan, machoMan);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"\n[Triple Threat Match creation validation working] {ex.Message}");
}

// Assemble the card
Console.WriteLine();
MatchCard card = new MatchCard("Fantasy Warfare");
card.AddMatch(opener);
card.AddMatch(intercontinentalChampionship);
card.AddMatch(tagTeamChampionship);
card.AddMatch(worldChampionship);
card.AddMatch(mainEvent);

Console.WriteLine(card.GetCardSummary());