using System;

/*
	In C#, when we don't want a class to be inherited by another class, we can declare the class as a sealed class.
*/

public sealed class CreditCardProcessor // A sealed class is a class that cannot be inherited.
{
    public void ProcessPayment(string cardNumber, double amount)
    {
        Console.WriteLine($"Processing payment of ${amount} with card: {cardNumber}");
    }
}



// ❌ Error: cannot derive from sealed type 'CreditCardProcessor'
// public class MyFakeProcessor : CreditCardProcessor
// {
//     // not allowed
// }


// class Program
// {
//     static void Main(string[] args)
//     {
//         CreditCardProcessor processor = new CreditCardProcessor();
//         processor.ProcessPayment("1234-5678-9012-3456", 99.99);
//     }
// }
