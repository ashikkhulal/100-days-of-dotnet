using System;

public class Program : IFullTimeEmployee, IPartTimeEmployee, IRetiredEmployee
{
    public static void Main()
    {
        // Default implementation
        Program program = new Program();
        program.Info();

        // Explicit implementation
        ((IPartTimeEmployee)program).Info();

        // Third way to implement an interface method
        IRetiredEmployee retiredEmployee = new Program();
        retiredEmployee.Info();

    }

    public void Info()
    {
        Console.WriteLine("Implementation of IFullTimeEmployee interface");
    }

    void IPartTimeEmployee.Info()
    {
        Console.WriteLine("Implementation of IPartTimeEmployee interface");
    }

    void IRetiredEmployee.Info()
    {
        Console.WriteLine("Implementation of IRetiredEmployee interface");
    }
}

interface IFullTimeEmployee
{
    void Info () { }
}

interface IPartTimeEmployee
{
    void Info() { }
}

interface IRetiredEmployee
{
    void Info() { }
}