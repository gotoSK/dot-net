// Lab 12 : WAP for handling errors in C# using exception handling.

using System;

class Program
{
	static void Main(string[] args)
	{
		int divisor;
		// code that might throw error or exception
		try
		{

			Console.WriteLine("Enter a number: ");
			divisor = Convert.ToInt32(Console.ReadLine());
			int a = 10 / divisor;
		}
		catch (Exception ex)
		{
			Console.WriteLine("The error occured:{0}",ex);
		}
		Console.ReadKey();
	}
}
