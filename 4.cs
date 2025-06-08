//Lab 6: WAP to call base classs constructor using "base" keyword

using System;

 public class Base
{
	public int v;
	public Base(int value)
	{
		v = value;
	}
}

public class Derived : Base
{
	public Derived(int value) : base(value)
	{
	}

	public void display()
	{
		Console.WriteLine("The value is: {0}", base.v);
	}
}

class Program
{
	static void Main()
	{
		Derived d = new Derived(5);
		d.display();
		Console.ReadKey();
	}
}

