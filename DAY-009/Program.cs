using System;

public class Program
{
    public static void Main()
    {
        // Single line comment
        // Console.WriteLine("Hello World");

        // Multi-line comment
        /*Console.WriteLine("Hello World");
        Console.WriteLine("Hello World");
        Console.WriteLine("Hello World");*/

        // Shortcut: Ctrl + K, Ctrl + C to comment and  Ctrl + K, Ctrl + U to uncomment

        Employee employee = new Employee();

    }
}

/// <summary>
/// An employee class (This is a sample xml documentation)
/// </summary>
public class Employee
{
    public string FirstName;
    public string LastName;
}