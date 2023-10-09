# DAY-002:

## Reading and writing to console:
```
using System;

class Program
{
    public static void Main(string[] args)
    {
        // Print program welcome info
        Console.WriteLine("Welcome to your greeter!\n");
        
        // Prompt user for his first name
        Console.Write("Please enter your first name: ");
        string firstName = Console.ReadLine();
        
        // Prompt user for his last name
        Console.Write("Please enter your last name: ");
        string lastName = Console.ReadLine();
        
        // Concatenate first name and last name and print
        Console.WriteLine("\nUsing string concatenation:");
        Console.WriteLine("Hello, " + firstName + " " + lastName);
        

        // Placeholder syntax to print first name and last name
        Console.WriteLine("\nUsing placeholder syntax:");
        Console.WriteLine("Hello, {0} {1}", firstName, lastName);
    }
}
```