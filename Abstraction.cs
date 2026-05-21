namespace OOPS;
public abstract class Shape
{
    // We cannot create an instance of an abstract class.
    // the outermost abstract class cannot be protected or private, only public or internal.
    // inner abstract classes can have desired access controls. 
    private abstract class InnerShape
    {
        // abstract/virtual methods cannot be private, but other access modifiers are allowed.
        public abstract void DisplayShapeInfo();
    }

    // defines implementation of abstract method in the InnerShape class. This is a concrete class that can be instantiated.
    private class Star : InnerShape
    {
        // access modifiers of overriding dervied methods should be same as parent abstract/virtual methods.
        public override void DisplayShapeInfo()
        {
            Console.WriteLine("This is a star shape.");
        }
    }

    // abstract properties, value must be provided by any non-abstract class that inherits from Shape
    public abstract string ShapeName { get; set; }
    
    // this is an abstract method, logic must be implemented by any non-abstract class that inherits from Shape
    public abstract double GetArea();

    //abstract classes may have non-abstract methods.
    public void ShowShapeInfo()
    {
        Star star = new();
        star.DisplayShapeInfo();
        Console.WriteLine($"Shape Name: {ShapeName}, Area: {GetArea()}");
    }
}

// Circle class inherits from Shape and provides implementation for the abstract members.
public class Circle : Shape
{
    public int Radius { get; set; } = 5;

    // implementation of the abstract property ShapeName
    public override string ShapeName { get; set; } = "Circle";

    // implementation of the abstract method GetArea
    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

// cannot create object (instantiation) of static class, and all members of a static class must be static as well.
public static class Rectangle
{
    // static methods can be called without creating an instance of the class, 
    // they belong to the class itself rather than any specific object.
    public static double GetArea(double width, double height)
    {
        return width * height;
    }
}

// Partial classes allow us to split the definition of a class across multiple files. 
// The compiler will combine all parts of the partial class into a single class at compile time.
// The name of the partial class must be the same across all files, and all parts must be marked with the partial keyword.
public partial class Triangle : Shape
{
    public double Base { get; set; }
    public double Height { get; set; }
    public override string ShapeName { get; set; } = "Triangle";

    // Sealed method cannot be overridden by any derived class
    // it provides a final implementation of the method in the base class.
    public sealed override double GetArea()
    {
        return 0.5 * Base * Height;
    }

    // new keyword is used to hide the base class method with the same name.
    public new void ShowShapeInfo()
    {
        Console.WriteLine($"This is a triangle shape with base {Base} and height {Height}.");
    }
}

public partial class Triangle
{
    // Asynchronous method to display triangle information, simulating a long-running operation.
    public async Task DisplayTriangleInfoAsync()
    {
        await Task.Run(() => Console.WriteLine($"Shape Name: {ShapeName}, Area: {GetArea()}"));
    }
}

// We cannot inherit from a sealed class, and a sealed class cannot be used as a base class for any other class. 
//Sealed classes are often used to prevent further inheritance and to provide a final implementation of a class.