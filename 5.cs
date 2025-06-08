// Lab9: WAP to implement polymorphism

using System;
using System.Runtime.InteropServices;

class Calculator
{
	public int Add(int  a,int b)
	{
		return a + b;
	}
	public double Add(double a,double b)
	{
		return a + b;
	}
}
class Program
{
	static void Main()
	{
		Calculator c = new Calculator();

		Console.WriteLine("Result int: {0}", c.Add(1, 2));
		Console.WriteLine("Result float: {0}", c.Add(4.54, 34.3));
		Console.ReadKey();
	}
}


