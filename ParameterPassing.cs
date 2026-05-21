namespace OOPS;

public class Places
{
    public static void NormalChangeName(string newName)
    {
        // since string is passed by value, the original variable city in the Main method will remain unchanged after this method call.
        newName = "Kochi";
    }

    // ref keyword is used to pass an argument by reference, allowing the method to modify the original variable passed in.
    // ref REQUIRES that the variable be initialized before it is passed to the method.
    public static void RefChangeName(ref string newName)
    {
        // since reference is passed, the original variable city in the Main method will be modified to "Kochi" after this method call.
        newName = "Kochi";
    }

    //  out is only sending data from the method to the caller, 
    // and it does not require the variable to be initialized before being passed to the method.
    public static void OutChangeName(out string newName)
    {
        newName = "Trivandrum";
    }

    // Normally parameters create copies which can be expensive for large data structures. 
    // The in avoids copy but keeps safety by making it read-only.
    public static void InChangeName(in string newName)
    {
        // newName = "Kochi"; // This will cause a compile-time error because in parameters are read-only.
        Console.WriteLine(newName);
    }
}