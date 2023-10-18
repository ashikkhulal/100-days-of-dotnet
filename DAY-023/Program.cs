using System;

public class Program
{
    public static void Main()
    {
        Employee[] employees = new Employee[4];
        employees[0] = new Employee();
        employees[1] = new FTEmployee();
        employees[2] = new PTEmployee();
        employees[3] = new TempEmployee();

        foreach (Employee e in employees)
        {
            e.PrintFullName();
        }
    }
}

public class Employee
{
    public string FirstName = "FN";
    public string LastName = "LN";

    public virtual void PrintFullName()
    {
        Console.WriteLine("Fullname: {0} {1}", FirstName, LastName);
    }
}

public class FTEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine("Fullname: {0} {1} - Full Time Employee", FirstName, LastName);
    }
}

public class PTEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine("Fullname: {0} {1} - Part Time Employee", FirstName, LastName);
    }
}

public class TempEmployee : Employee
{

}