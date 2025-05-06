using System;


// ***************** constractor   less parametre  *************

/*
class clsPerson
{

    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public clsPerson() // *********** public constractor and Parametre-less Constractor
    {
        Id = -1;
        Name = "Empty";
        Age = 0;
    }
}

internal class Program
{



    // we can use it :
    // 1 - initialize variable ?? save data base

    static void Main(string[] args)
    {
        clsPerson Person1 = new clsPerson();

        Console.WriteLine("ID:= {0}", Person1.Id);
        Console.WriteLine("Name:= {0}", Person1.Name);
        Console.WriteLine("Age:= {0}", Person1.Age);
        Console.ReadKey();
    }
}


*/



// **********  parametrized Constractor *************


/*
class clsCar
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }

    public clsCar(int Id, string Name, string Color)
    {
        this.Id = Id;
        this.Name = Name;
        this.Color = Color;
    }

}

internal class Program
{
    static void Main(string[] args)
    {
        clsCar car1 = new clsCar(2024, "bmw", "black");

        Console.WriteLine($"car name : {car1.Name} \nid = {car1.Id} \ncolor = {car1.Color}");

    }
}

*/


// **********************  default constractor ***********


/*
 * If we have not defined a constructor in our class,
 * then the C# will automatically create a default constructor with an empty code and no parameters.
 *
 *
 * ila madrtich constractor rah kaydiro nyaba 3leek hahahah  ay class rah fiha default constractor wakha maykonchi dayr
 *
 */




// *********************** Private Constractor vs static Class C# **


using System;


//   static  class clsfoo // ************** option 2

class clsfoo
{
    private clsfoo() { } // option 1 :   this is a private constructor to prevent creating object from this class
    public static string To_day
    {
        get { return DateTime.Today.DayOfWeek.ToString(); }
    }

    public static string Task { get; set; }

}

class Constructor
{
    static void Main(string[] av)
    {
        //clsfoo d_ay = new clsfoo();
        // d_ay.Task = "Golang";  //  *****  you can't access a static method using object


        clsfoo.Task = "learn Golang";

        Console.WriteLine($"Today : {clsfoo.To_day}");
        Console.WriteLine($"Task : {clsfoo.Task}");

        // *** If you want to prevent creating objects from a class, you have two correct options : **

        // ***** ✅ Option 1: Make the constructor private ****

        // ***** ✅ Option 2: Make the entire class static ****




        // **********  Ummmm : If your class does not have static members, and you still want to prevent object creation ???

        // *** 1 - you should use a private constructor ✅.

        // *** 2 - You cannot make the class static unless all its members are also static.


        /*
        * 🔸 Why?
            static class ➜ means everything inside must be static (methods, properties, etc.).

            If you have non-static members, you can’t use a static class.

            But you can make a normal class with a private constructor to block object creation.
        */





        // ****   Ummmm I can use both at the same time ????

        /*
         * You cannot use a private constructor in a static class, because:
            A static class does not allow any constructor to be written at all — not even private.

            C# automatically adds a private static constructor for you behind the scenes in a static class.

            ❗ This gives a compiler error: "A static class cannot have instance constructors"

        */


    }
}
