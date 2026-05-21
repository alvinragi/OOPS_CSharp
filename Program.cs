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
        

    }
}