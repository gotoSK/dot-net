// Lab 18: WAp to count the number of vowels and consonants in a string
using System;

class Program
{


	static void Main()
	{
		int countVow = 0;
		int countConst = 0;

		Console.WriteLine("Enter a string:\n");
		string str = Console.ReadLine();

		char[] arr = ['a', 'e', 'i', 'o', 'u'];

		for (int i = 0; i < str.Length; i++)
		{
			for (int j = 0; j < arr.Length; j++)
			{
				if (str[i] == arr[j])
				{
					countVow++;
				}
			}

		}

		Console.WriteLine("No. of vowels is {0}",countVow);
		countConst = str.Length - countVow;
		Console.WriteLine("No. of consonants is {1}",countConst);
	}
}
