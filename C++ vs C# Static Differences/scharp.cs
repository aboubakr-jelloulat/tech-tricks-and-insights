
using System;

class StaticDifferences
{
    // Static variable initialization directly in the class in C#
    public static int x = 1337; // In C#, static variables can be initialized inside the class directly

    // Static counter variable
    public static int counter = 0;

    public static int Foo()
    {
        return x;  // Static methods can access static variables directly
    }


    public static int Increment()
    {
        return ++counter;  // Increment and return the static counter
    }

    static void Main(string[] args)
    {
        // 📌 **Accessing static variables** in C#

        // In C#, static members are accessed using the class name
        Console.WriteLine("Variable: " + StaticDifferences.x); // Accessing static variable using class name
        Console.WriteLine("Foo function: " + StaticDifferences.Foo()); // Accessing static method using class name

        // 📌 **Modifying static variables**

        // Modifying static variables in C# is done via the class name
        StaticDifferences.x = 42;  // In C#, modify static variable using class name
        Console.WriteLine("Modified Variable: " + StaticDifferences.x);
        Console.WriteLine("Foo function after modification: " + StaticDifferences.Foo());

        // 📌 **Using static method to modify another static variable (counter)**

        // Static methods can also modify static variables

        Console.WriteLine("Counter: " + StaticDifferences.Increment()); // Increment static counter
        Console.WriteLine("Counter: " + StaticDifferences.Increment());
        Console.WriteLine("Counter: " + StaticDifferences.Increment());

        // 📌 **Accessing static members via object**

        StaticDifferences dif = new StaticDifferences();  // Create an object of StaticDifferences

        // You can access static members through the object, but you will get a warning:

        // 🚸 🚸🚸 cannot be accessed through object, only through the class itself

        //Console.WriteLine("Accessing static variable via object: " + dif.x);
        //Console.WriteLine("Accessing static method via object: " + dif.Foo());


    }
}

/*
   🚀 **Key Differences Between C++ and C# in Static Variables**:

   1. **Static Variable Initialization**:
      - In **C++**, static variables must be defined outside the class using the `ClassName::var` syntax.
      - In **C#**, static variables can be initialized directly **inside the class** (no need for definition outside the class).
      - Example (C#): `public static int x = 1337;`

   2. **Modifying Static Variables**:
      - In **C++**, you can modify static variables **using an object** (but it's still recommended to use the class name).
      - In **C#**, static variables must be modified using the **class name**, as static members belong to the class and not instances.
      - Example (C#): `StaticDifferences.x = 42;` (No object is needed here)

   3. **Accessing Static Members**:
      - In both **C++** and **C#**, static members belong to the class itself and can be accessed without an object.
      - **C#** requires you to explicitly access static members using the **class name** (e.g., `StaticDifferences.x`), whereas **C++** allows access via both the class name and object.

   4. **Static Methods**:
      - Both languages support **static methods** that can access and modify static variables.
      - In **C++**, static methods can be called via the class name or an object, while in **C#**, static methods must always be called via the class name.

   5. **Memory**:
      - Both C++ and C# use shared memory for static variables, meaning that all instances of the class share the same static variable.
      - However, C# manages memory via the .NET runtime, while C++ gives you manual control over memory allocation.

   **Summary**:
   - Static variables and methods are similar in both languages but require different syntax for initialization and modification.
   - C# enforces a more structured approach by restricting the modification of static members via class names, while C++ is a bit more flexible.
*/
