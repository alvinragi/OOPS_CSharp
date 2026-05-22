namespace OOPS;
public class Program
{
    public static async Task Main(string[] args)
    {

        // 1. AccessModifiers.cs
        Dog dog = new();
        dog.DisplayInfo();

        Puppy puppy = new();
        puppy.DisplayAnimalInfo();

        // 2. Abstraction.cs
        // creating an instance of a derived class that implements the abstract members.
        Circle circle = new() { ShapeName = "Circle", Radius = 5 };
        circle.ShowShapeInfo();
        // calling the static method in the Rectangle class without creating an instance of the Rectangle class.

        Rectangle.GetArea(4, 5);
        //triangle is a partial class where the below methods are defined in different class files.

        Triangle triangle = new() { ShapeName = "Triangle", Base = 4, Height = 5 };
        // calling the asynchronous method to display triangle information, simulating a long-running operation.
        await triangle.DisplayTriangleInfoAsync();
        triangle.GetArea();

        Square square = new(5, "Red");
        Square secondSquare = new(5, "Red");
        // creates a new instance of Square with the same values as the original square.
        Square anotherSquare = square with { Color = "Blue" }; 
        // true, because records have value-based equality by default.
        Console.WriteLine( square == secondSquare); 
        // we can easily console properties of record because tostring method is automatically generated for records.
        Console.WriteLine(anotherSquare);


        // 3. FieldAndConstructorModifiers.cs
        Fruit fruit = new("Apple", 100) { Taste = "Sweet", Type = "Citrus" };
        fruit.CalculateCalories();
        Console.WriteLine($"Fruit Name: {fruit.name}, Taste: {fruit.Taste}, Type: {fruit.Type}, Calories: {fruit.Calories}");

        // we cannot initialize Drinks using a constructor since it has a private constructor
        // we can only create an instance of Drinks using the static method CreateDrinks() defined in the Drinks class.
        Drinks drinks = Drinks.CreateDrinks();
        Console.WriteLine($"Drink Name: {drinks.Name}");

        Cakes cake = new() { CakeName = "Vanilla Cake" };
        Console.WriteLine($"Cake Name: {cake.CakeName}, Default Dessert: {cake.SecondaryOption}");

        // nameof operator is used to get the name of a variable, type, or member as a string. 
        Console.WriteLine(nameof(Program));

        // is operator is used to check if an object is of a specific type. It returns true if the object is of the specified type, and false otherwise.
        if(cake is Cakes)
        {
            // typeof operator is used to get the System.Type object for a type.
            Console.WriteLine(typeof(Cakes));
        }

        // as operator is used to perform a safe type conversion. It attempts to cast an object to a specified type, and returns null if the conversion fails instead of throwing an exception.
        Drinks drink2 = drinks as Drinks; 
        

        // 4. ParameterPassing.cs
        string city = "Delhi";
        // city is passed by value, so the original value of city remains unchanged after the method call.
        Places.NormalChangeName(city);
        Console.WriteLine(city);
        // city is passed by reference, so the original value of city is changed to "Kochi" after the method call.
        Places.RefChangeName(ref city);
        Console.WriteLine(city);
        string city2;
        // non initialized variable city2 is passed by reference using the out keyword
        Places.OutChangeName(out city2);
        Console.WriteLine(city2);
        Places.InChangeName(city);

        // 5. Generics.cs
        Plant<Flower, int> plant =
            new Plant<Flower, int>();

        plant.PlantData.Species = "Rose";
        plant.AddGrowthValue(10);
        plant.PlantData.Water();
        // Since PrintValue is a generic method, we can call it with different types of arguments.
        plant.PrintValue<string>("Healthy");
        plant.PrintValue<int>(100);


        // 6. StructsAndInterfaces.cs
        Bicycle bicycle = new() { Speed = 15, Gear = 3 };
        Bicycle anotherBicycle = bicycle; // This creates a copy of the bicycle struct, since structs are value types.
        anotherBicycle.Speed = 20; // This change does not affect the original bicycle instance.
        Console.WriteLine($"Another Bicycle Speed: {anotherBicycle.Speed}, Another Bicycle Gear: {anotherBicycle.Gear}");
    }
}