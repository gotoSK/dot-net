// Lab 19: WAP to check if the given word is a palindrome
using System;


class Program
{


	static void Main()
	{
		Console.WriteLine("Enter a string:");
		string str = Console.ReadLine();

		string revStr = String.Empty;

		for (int i = str.Length - 1; i >= 0; i--)
		{
			revStr += str[i];
		}

		if (revStr == str)
		{
			Console.WriteLine($"Given string {str} is a palindrome");
		}

		if (revStr != str)
		{
			Console.WriteLine($"Given string {str} is a not a palindrome");
		}

		Console.ReadKey();
	}

}
