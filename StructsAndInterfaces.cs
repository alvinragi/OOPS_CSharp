namespace OOPS;

public interface IVehicle
{
    // An interface can contain method signatures, properties, events, and indexers, but it cannot contain fields or constructors.
    void Start();
    void Stop();
    // any class inheriting from IVehicle must implement the Speed property.
    int Speed { get; set; }
}

// An interface can inherit from another interface. In this case, ICar inherits from IVehicle, 
// which means that any class that implements ICar must also implement the members of IVehicle.
public interface ICar : IVehicle
{
    void OpenTrunk();
}

// A class can implement multiple interfaces. 
public class Car : ICar, IVehicle
{
    public int Speed { get; set; }

    public void Start()
    {
        Console.WriteLine("Car started.");
    }

    public void Stop()
    {
        Console.WriteLine("Car stopped.");
    }

    public void OpenTrunk()
    {
        Console.WriteLine("Trunk opened.");
    }
}

// Strcts are value types and can also implement interfaces.
public struct Bicycle : IVehicle
{
    public int Speed { get; set; }
    public int Gear { get; set; }
    public int MaxSpeed { get; set; }

    // can implement a constructor in a struct, but it must initialize all fields of the struct.
    public Bicycle()
    {
        MaxSpeed = 30; // Default value for MaxSpeed
    }

    public void Start()
    {
        Console.WriteLine("Bicycle started.");
    }

    public void Stop()
    {
        Console.WriteLine("Bicycle stopped.");
    }
}