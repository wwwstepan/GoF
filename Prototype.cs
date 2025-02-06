using static My.CommonTools;

namespace GoF;

public class UsePrototype
{
    public UsePrototype()
    {
        print(Prototype.Clone(new Car("Audi", 220, 4)));
        print(Prototype.Clone(new Sheep("Витязь", 35, 200)));
    }
}

public class Prototype
{
    public string? Name;
    public string? Model;
    public double Speed;

    public static Prototype Clone(Car z) => new() { Model = z.Model, Speed = z.Speed };
    public static Prototype Clone(Sheep z) => new() { Name = z.Name, Speed = z.Speed };

    public override string ToString() => $"Name: {Name} Model: {Model} Speed: {Speed}";
}

public record Car(string Model, double Speed, int CountOfWheels);
public record Sheep(string Name, double Speed, int CountOfGuns);
