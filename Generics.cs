namespace OOPS;
public class LivingThing
{
    public string Species { get; set; } = "";
}

public interface IWaterable
{
    void Water();
}

public class Flower : LivingThing, IWaterable
{
    public void Water()
    {
        Console.WriteLine("Flower watered");
    }
}

// Plant is a generic class with two type parameters T and U, 
// where T must be a LivingThing that implements IWaterable and has a parameterless constructor.
public class Plant<T, U>
    where T : LivingThing, IWaterable, new()
{
    public T PlantData { get; set; }
    public U ExtraData { get; set; }

    // No Boxing/Unboxing in Generics: The _growthValues list can store values of type U without boxing/unboxing.
    private List<U> _growthValues = new List<U>();

    public Plant()
    {
        // new() constraint usage
        PlantData = new T();
    }

    public void AddGrowthValue(U value)
    {
        _growthValues.Add(value);
    }

    // Generic Method inside Generic Class
    public void PrintValue<V>(V value)
    {
        Console.WriteLine($"Value: {value}");
    }
}