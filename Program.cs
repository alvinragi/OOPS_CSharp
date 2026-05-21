public class Program
{
    public static void Main(string[] args)
    {

        // 1. AccessModifiers.cs
        Dog dog = new Dog();
        dog.DisplayInfo();
        Puppy puppy = new Puppy();
        puppy.DisplayAnimalInfo();

        // 2. Abstraction.cs
        // creating an instance of a derived class that implements the abstract members.
        Circle circle = new Circle { ShapeName = "Circle", Radius = 5 };
        circle.ShowShapeInfo();
    }
}