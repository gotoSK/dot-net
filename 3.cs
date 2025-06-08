//Lab 4: WAP to calculate Area of rectanngle using single inheritance

using System;

class Rectangle
{
	public int length;
	public int breadth;
}

class AreaRectangle: Rectangle
{
	public void area(double l, double b)
	{
		Console.WriteLine("Area of rectangle through inheritance: {0}", l * b);
	}

}
class Program
{
	static void Main()
	{
		AreaRectangle a = new AreaRectangle();

		a.area(100, 24);
		Console.ReadKey();

	}
}
