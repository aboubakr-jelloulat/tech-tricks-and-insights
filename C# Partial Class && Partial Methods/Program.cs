using System;

/*
	There are many situations when you might need to split a class definition, such as when working on a large scale projects, multiple developers and programmers might need to work on the same class at the same time.
	In this case we can use a feature called Partial Class

*/



/*
	A partial class allows you to split the definition of a class into multiple files.
	All parts are combined into a single class when the application is compiled.

*/




/*

	A partial method lets you define a method in one part of a partial class, and optionally implement it in another part.

	🔸 If you don’t implement it, it gets removed at compile time — so no performance cost.


	Things to remember about Partial Method : 
		partial keyword.
		return type void.
		implicitly private.
		and cannot be virtual.


*/

internal class Program
{
	public static void Main(string[] av)
	{
		clsPartial obj = new clsPartial();

		obj.Method1();
		obj.Method2();

		System.Console.WriteLine("\n  **** Partial Method : \n");

		obj.Age = 20;
		obj.PartialMethod1();
	}
}
