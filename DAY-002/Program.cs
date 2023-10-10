using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to your greeter!\n");
        Console.Write("Please enter your first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Please enter your last name: ");
        string lastName = Console.ReadLine();

        Console.WriteLine("\nUsing string concatenation:");
        Console.WriteLine("Hello, " + firstName + " " + lastName);

        Console.WriteLine("\nUsing placeholder syntax:");
        Console.WriteLine("Hello, {0} {1}", firstName, lastName);
    }
}
