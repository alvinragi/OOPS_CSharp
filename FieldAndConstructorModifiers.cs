namespace OOPS;

// using primary constructor (string name) to initialize the readonly field 'name' in the Fruit class.
public class Fruit(string name, int weight)
{
    // readonly fields can only be assigned in the constructor or at the point of declaration, and cannot be modified afterwards.
    // if constructor is not defined, no values can be set to the field and will be null. 
    public readonly string name = name;

    // if primary constructor is not used, we can define a constructor to initialize the readonly field 'name' as shown below.
    // public Fruit(string name)
    // {
    //     this.name = name;
    // }

    // const fields must be initialized at the point of declaration and cannot be modified afterwards. 
    // They are implicitly static, so they belong to the class rather than any instance of the class.
    const string category = "Food"; 

    public string? Taste { get; set; }
    public string Type { get; set; } = "Unknown";

    // private set accessor allows the Calories property to be set only within the Fruit class, while it can be read from outside the class.
    public int SalePrice { get; private set; } = 100; // default value of 100 grams
    public int Weight { get; private set; } = weight; // using primary constructor to initialize the readonly field 'weight'.
    public int Calories { get; private set; }

    // method to calculate calories based on weight, and set the Calories within the class, since it has a private set accessor.
    public void CalculateCalories()
    {
        Calories = Weight * 2; 
    }
    // private get is not common. 
}

public class Drinks
{
    public readonly string Name = "Pepsi";

    // Private Constructor. Only Drinks class  an create a constructor. 
    private Drinks() { }

    public static Drinks CreateDrinks()
    {
        return new Drinks();
    }
}

public class Desserts
{
    public const string DefaultDessert = "Ice Cream";

    // Protected Constructor. Only Desserts can create a constructor, but it can be inherited by child classes. 
    protected Desserts() { }
}

public class Cakes : Desserts
{
    public string CakeName { get; set; } = "Chocolate Cake";
    public string SecondaryOption = DefaultDessert;
}