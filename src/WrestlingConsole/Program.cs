using WrestlingCore;

Console.Write("Name: ");
string name = Console.ReadLine()!;
Console.Write("Age: ");
int age = int.Parse(Console.ReadLine()!);
Console.Write("Height (inches): ");
int height = int.Parse(Console.ReadLine()!);
Console.Write("Finishing Move: ");
string finishingMove = Console.ReadLine()!;


Wrestler wrestler = new Wrestler(name, age, height, finishingMove);

Console.WriteLine($"Name: {wrestler.Name}");
Console.WriteLine($"Age: {wrestler.Age}");
Console.WriteLine($"Height: {wrestler.Height} inches");
Console.WriteLine($"Finishing Move: {wrestler.FinishingMove}");