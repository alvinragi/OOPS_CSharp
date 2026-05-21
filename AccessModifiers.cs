public class Animal
{
    // this property is public, so it can be accessed from anywhere
    public string Name { get; set; } = "Tommy";
 
    // this property is private, so it can only be accessed within the Animal class
    private int Age { get; set; } = 1;
 
    // this property is protected, so it can be accessed within the Animal class and its derived classes
    protected string Species { get; set; } = "Terra";

    // this method is protected, so it can be accessed within the Animal class and its derived classes
    public virtual int GetAge()
    {
        return Age;
    }

    protected void ShowDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Species: {Species}");
    }
    
}

public class Dog : Animal
{
    // not an override, but rather a new field that happens to have the same name as the Age property in the Animal class.
    private int Age = 2;

    // overrides the GetAge() method in the Animal class with new implementation.
    public override int GetAge()
    {
        Console.WriteLine($"Dog's Age: {Age}");

        // returns the value of the age field in the Dog class, not the Age property in the Animal class
        return Age; 
    }
    public void DisplayInfo()
    {
        // calls the method in the Dog class, not method in the Animal class due to method overriding. 
        GetAge();

        // using the base keyword to call the GetAge() method in the Animal class.
        int age = base.GetAge(); 

        Console.WriteLine($"AnimalName: {Name},Animal Age: {age},Animal Species: {Species}");
    }

}
public class Puppy : Dog
{
    public void DisplayAnimalInfo()
    {
        // this works because protected members are accessible thoroughout the inheritance chain, so the Puppy class can access the Animal class's protected members through the Dog class
        ShowDetails(); 
    }
}
