using WrestlingCore;

Console.Write("Name: ");
string name = Console.ReadLine()!;
Console.Write("Age: ");
int age = int.Parse(Console.ReadLine()!);
Console.Write("Height (inches): ");
int height = int.Parse(Console.ReadLine()!);

Person person = new Person(name, age, height);
Console.WriteLine($"Name: {person.Name}");
Console.WriteLine($"Age: {person.Age}");
Console.WriteLine($"Height: {person.Height} inches");