//Lab 3: WAP to initialize and dispaly a 2d array elements with sum of each row

using System;


class Program
{

	static void Main()
	{
		int[,] arr = new int[3, 3]
		{
			{5,6,7},
			{6,7,8},
			{7,8,9}
		};
		int sum;

		for(int i = 0; i < arr.GetLength(0); i++)
		{
			sum = 0;
			Console.Write("{0} row: ", i + 1);
			for(int j = 0; j < arr.GetLength(1); j++)
			{
				sum = sum + arr[i, j];
				Console.Write(arr[i, j]+"  ");
			}
			Console.WriteLine("\nSum of elements: {0}\n", sum);
		}
		Console.ReadKey();
	}
}
