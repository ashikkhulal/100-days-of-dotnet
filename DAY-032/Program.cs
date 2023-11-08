using System;

public class Program : Customer
{
    public static void Main()
    {
        Program program = new Program();
        program.Print();

        Customer customer = new Program();
        customer.Print();
        customer.NonAbstractMethod();
    }

    public override void Print() 
    {
        Console.WriteLine("Implementation of print method from Customer abstract class");
    }
}

public abstract class Customer
{
    public abstract void Print();

    public void NonAbstractMethod()
    {
        Console.WriteLine("Hello");
    }
}