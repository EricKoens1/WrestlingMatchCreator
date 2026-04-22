namespace WrestlingCore;

public class Person
{
    // properties
    public string Name { get; set; }
    public int Age { get; set; }
    public int Height { get; set; }

    // default constructor
    public Person(string name, int age, int height)
    {
        this.Name = name;
        this.Age = age;
        this.Height = height;
    }
}