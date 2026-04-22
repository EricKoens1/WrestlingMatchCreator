using WrestlingCore;

// Wrestlers
Wrestler hogan = new Wrestler("Hulk Hogan", 70, 78, "Leg Drop",
    WeightClass.Heavyweight, ExperienceLevel.Legend);
Wrestler macho = new Wrestler("Macho Man", 58, 73, "Flying Elbow",
    WeightClass.Heavyweight, ExperienceLevel.Legend);
Wrestler rock = new Wrestler("The Rock", 51, 77, "People's Elbow",
    WeightClass.Heavyweight, ExperienceLevel.SeasonedVet);
Wrestler stoneCold = new Wrestler("Stone Cold", 61, 74, "Stunner",
    WeightClass.Heavyweight, ExperienceLevel.Legend);
Wrestler undertaker = new Wrestler("The Undertaker", 60, 82, "Tombstone",
    WeightClass.Heavyweight, ExperienceLevel.Legend);
Wrestler kane = new Wrestler("Kane", 58, 80, "Chokeslam",
    WeightClass.Heavyweight, ExperienceLevel.Legend);
Wrestler reyMysterio = new Wrestler("Rey Mysterio", 49, 66, "619",
    WeightClass.Cruiserweight, ExperienceLevel.Legend);

// Teams
Team megaPowers = new Team("The Mega Powers", hogan, macho);
Team brothersOfDestruction = new Team("Brothers of Destruction", undertaker, kane);

// Matches (all three types!)
NormalMatch opener = new NormalMatch(rock, stoneCold);
TagTeamMatch tag = new TagTeamMatch(megaPowers, brothersOfDestruction);
TripleThreatMatch mainEvent = new TripleThreatMatch(hogan, stoneCold, reyMysterio);

// Assemble the card
MatchCard card = new MatchCard("WrestleMania XL");
card.AddMatch(opener);
card.AddMatch(tag);
card.AddMatch(mainEvent);

Console.WriteLine(card.GetCardSummary());