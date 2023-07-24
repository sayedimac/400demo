// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


List<Animal> animals = new List<Animal>
{
    new Animal { Name = "Fluffy", Age = 3, Color = "White", Type = "Cat", Sound = "Meow" },
    new Animal { Name = "Buddy", Age = 5, Color = "Brown", Type = "Dog", Sound = "Woof" },
    new Animal { Name = "Nibbles", Age = 1, Color = "Gray", Type = "Hamster", Sound = "Squeak" }
};

foreach (Animal animal in animals)
{
    Console.WriteLine($"Name: {animal.Name}, Age: {animal.Age}, Color: {animal.Color}, Type: {animal.Type}, Sound: {animal.Sound}");
}
public class Animal {
    public string? Name { get; set; }
    public int? Age { get; set; }
    public string? Color { get; set; }
    public string? Type { get; set; }
    public string? Sound { get; set; }
}

