// Lab 15: WAp to store five student names and addresses in a list and print in both ascending and descending order by name.

using System;
using System.Collections.Generic;

public class Student
{
	public string address
	{
		get;
		set;
	}
	public string name
	{
		get;
		set;
	}
}
class Program
{
	static void Main()
	{
		List<Student> stuDetails = new List<Student>() {
			new Student{address="KTM", name="Ram"},
			new Student{address="BKT", name="Laxman"},
			new Student{address="SRI", name="Ravan"},
			new Student{address="BIR",name="Sita"},
			new Student{address="PKR",name="Lav"}
		};

		var ascending = stuDetails.OrderBy(x => x.name);

		Console.WriteLine("In ascending order");
		foreach (var student in ascending)
		{
			Console.WriteLine("Name: {0}, Address: {1}",student.name,student.address);
		}

		var descending = stuDetails.OrderByDescending(x => x.name);
		Console.WriteLine("\n****************** \nIn descending order");
		foreach (var student in descending)
		{
			Console.WriteLine("Name: {0}, Address: {1}",student.name,student.address);
		}
		Console.ReadKey();

	}

}
