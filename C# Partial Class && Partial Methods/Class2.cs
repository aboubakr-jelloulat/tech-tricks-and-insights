using System;

public partial class clsPartial
{
	public void Method2()
	{
		System.Console.WriteLine("Hej ! I'm Method 2 file 2");
	}
	// ** In C#, partial methods cannot have access modifiers (like private, public, etc.).
	partial void PrintAge()
	{
		System.Console.WriteLine($"Age : {Age}");
	}
}
