// Lab 13: How to read and write files in C#
using System;
using System.IO;

class Program
{
	static void Main(string[] args)
	{
		string filepath = "sample.txt";

		// Writing in file
		File.WriteAllText(filepath, "Hello,How do you do?\nI am fine\nThank You");

		// Reading from a file
		string[] lines = File.ReadAllLines(filepath);
		foreach (string line in lines)
		{
			Console.WriteLine(line);
		}
	}
}
