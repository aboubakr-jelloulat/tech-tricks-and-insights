using System;

// ***************  Abstract class *********

/*
    An abstract class in C# is a class that cannot be instantiated directly.
    It is designed to be a base class from which other classes can inherit.

    Abstract class: is a restricted class that cannot be used to create objects
    (to access it, it must be inherited from another class)
*/

/*
    Abstract method: can only be used in an abstract class, and it does not have a body.
    The body is provided by the derived class (inherited from)
*/

// ********   The abstract keyword is used for classes and methods :
// 1 * You can’t create an object from an abstract class.
// 2 * Can contain abstract methods (methods without a body)

public abstract class clsBook
{
    public string _Title { get; set; }
    public string _Author { get; set; }

    public clsBook(string title, string author)
    {
        this._Title = title;
        this._Author = author;
    }

    public abstract void displayCategory();  // Abstract method: must be implemented in derived class
}

public class clsAlgorithmBook : clsBook
{
    public clsAlgorithmBook(string title, string author) : base(title, author) {}

    public override void displayCategory()
    {
        Console.WriteLine("Category : Algorithm");
    }
}

public class Program
{
    public static void Main(string[] args)
    {

        clsAlgorithmBook algobook = new clsAlgorithmBook("Intro to Algorithms", "Cormen");

        algobook.displayCategory();

		// clsBook book = new clsBook("book 1", "unknow");  ** Cannot create an instance of the abstract class or interface 'clsBook'
		// System.Console.WriteLine($"book : {book._Title}");
    }
}
