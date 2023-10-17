using System;

public class Program
{
    public static void Main()
    {
        FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
        fullTimeEmployee.FirstName = "John";
        fullTimeEmployee.LastName = "FullTime";
        fullTimeEmployee.PrintFullName();

        // Method hiding
        PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
        partTimeEmployee.FirstName = "Method";
        partTimeEmployee.LastName = "Hiding";
        partTimeEmployee.PrintFullName();

        // Method unhiding way 2
        partTimeEmployee.LastName = "Unhiding";
        ((Employee)partTimeEmployee).PrintFullName();
        // Method unhiding way 3
        Employee partTimeEmployee2 = new PartTimeEmployee();
        partTimeEmployee2.FirstName = "Method";
        partTimeEmployee2.LastName = "Unhiding";
        partTimeEmployee2.PrintFullName();

    }
}

public class Employee
{
    public string? FirstName;
    public string? LastName;

    public void PrintFullName()
    {
        Console.WriteLine("FullName: {0} {1}", FirstName, LastName);
    }
}

public class PartTimeEmployee: Employee
{
    public new void PrintFullName()
    {
        Console.WriteLine("FullName: {0} {1} - Contractor", FirstName, LastName);
    }

    // Method unhiding way 1
    //public void PrintFullNameFromBase()
    //{
    //    base.PrintFullName();
    //}
}

public class FullTimeEmployee : Employee
{

}