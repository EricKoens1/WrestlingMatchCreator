using WrestlingCore;

Console.Write("Name: ");
string name = Console.ReadLine()!;

Console.Write("Age: ");
int age = int.Parse(Console.ReadLine()!);

Console.Write("Height (inches): ");
int height = int.Parse(Console.ReadLine()!);

Console.Write("Finishing Move: ");
string finishingMove = Console.ReadLine()!;

Console.Write("Weight Class (SuperHeavyweight, Heavyweight, LightHeavyweight, Cruiserweight): ");
WeightClass weightClass = Enum.Parse<WeightClass>(Console.ReadLine()!, ignoreCase: true);

Console.Write("Experience Level (Trainee, Rookie, Veteran, SeasonedVet, Legend): ");
ExperienceLevel experienceLevel = Enum.Parse<ExperienceLevel>(Console.ReadLine()!, ignoreCase: true)!;

Wrestler wrestler = new Wrestler(name, age, height, finishingMove, weightClass, experienceLevel);

Console.WriteLine($"Name: {wrestler.Name}");
Console.WriteLine($"Age: {wrestler.Age}");
Console.WriteLine($"Height: {wrestler.Height} inches");
Console.WriteLine($"Finishing Move: {wrestler.FinishingMove}");
Console.WriteLine($"Weight Class: {wrestler.WeightClass}");
Console.WriteLine($"Experience Level: {wrestler.ExperienceLevel}");