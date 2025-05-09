using System;

/*
	🔐 What is a Sealed Method in C#?
		A sealed method is a method that cannot be overridden again in a derived class.

		🔸 You can only seal a method that overrides a method from a base class.
		🔸 You do this using the sealed keyword in combination with override.
*/


// 🏢 Real Scenario:


// ❌ This class tries to override the sealed method → ERROR!




public class Transport
{
    public virtual void Drive()
    {
        Console.WriteLine("Generic transport is moving...");
    }
}

public class Car : Transport
{
    public sealed override void Drive()
    {
        Console.WriteLine("Car is driving with GPS assistance...");
    }
}


public class Tesla : Car
{
    // Error: cannot override sealed member 'Car.Drive()'
    // public override void Drive()
    // {
    //     Console.WriteLine("Tesla is driving itself...");
    // }
}

class Program
{
    static void Main(string[] args)
    {
        Transport t = new Transport();
        t.Drive(); // Output: Generic transport is moving...

        Car car = new Car();
        car.Drive(); // Output: Car is driving with GPS assistance...
    }
}
