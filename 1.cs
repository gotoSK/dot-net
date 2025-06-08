// Lab1: WAP to add two digit using a constructor
using System;

class Program
{
	public int a;
	public int b;
	public int sum;

	public Program(int a,int b)
	{
		this.a = a;
		this.b = b;
		sum = a + b;
	}

	static void Main()
	{
		Program p = new Program(5, 6);
		Console.WriteLine("The sum of numbers is {0}",p.sum);
		Console.ReadKey();
	}
}
