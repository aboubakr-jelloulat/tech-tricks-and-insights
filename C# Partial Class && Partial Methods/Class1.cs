using System;

public partial class clsPartial
{
	public decimal Age {get; set;}
	public void Method1()
	{
		System.Console.WriteLine("Hej ! I'm Method 1 file 1");
	}

	partial void PrintAge();

	public void	PartialMethod1()
	{
		++Age;

		PrintAge();
	}

}
