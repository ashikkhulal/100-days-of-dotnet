using System;

public class Program
{
    public static void Main()
    {

    }
}

abstract class Customer
{
    private string _name;
    public void Print()
    {
        Console.WriteLine("Printing...");
    }
}

interface ICustomer
{
    void Print() { }
}