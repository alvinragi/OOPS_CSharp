namespace OOPS;
public abstract class Shape
{
    //the outermost abstract class cannot be protected or private, only public or internal.
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