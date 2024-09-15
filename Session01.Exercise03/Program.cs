public class Person
{
    public string Name { get; set; }

    public void Introduce()
    {
        Console.WriteLine($"Hi, I am {Name}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var person = new Person { Name = "Dimitar" };

        person.Introduce();
    }
}