using System;

public class Program
{
    public static void Main(string[] args)
    {
        FullTimeEmployee FTE1 = new FullTimeEmployee();
        FTE1.FirstName = "Sid";
        FTE1.LastName = "Thapar";
        FTE1.Email = "sid@example.com";
        FTE1.YearlySalary = 100000F;
        FTE1.EmployeeInfo();
        FTE1.FullTimeEmployeeInfo();

        PartTimeEmployee PTE1 = new PartTimeEmployee();
        PTE1.FirstName = "John";
        PTE1.LastName = "Doe";
        PTE1.Email = "john@example.com";
        PTE1.HourlyWage = 15F;
        PTE1.EmployeeInfo();
        PTE1.PartTimeEmployeeInfo();

    }
}

// Base class
public class Employee
{
    string? _firstName;
    string? _lastName;
    string? _email;

    public string FirstName { get { return _firstName;  } set { _firstName = value;  } }
    public string LastName { get { return _lastName; } set { _lastName = value; } }
    public string Email { get { return _email; } set { _email = value; } }

    public Employee() 
    {
        Console.WriteLine("Parent Class is first called: I am a parent class constructor.");
    }

    public Employee(string type)
    {
        Console.WriteLine("Parent Class is first called: Printing {0} employee details:", type);
    }

    public void EmployeeInfo()
    {
        Console.WriteLine("FullName: {0} {1}", this._firstName, this._lastName);
        Console.WriteLine("Email: {0}", this._email);
    }
}

public class FullTimeEmployee : Employee
{
    float _yearlySalary;
    public float YearlySalary { get { return _yearlySalary;  } set { _yearlySalary = value;  } }

    public FullTimeEmployee() : base ("Full Time")
    {
        Console.WriteLine("And then the child class constructor is called...");
    }

    public void FullTimeEmployeeInfo()
    {
        Console.WriteLine("Yearly Salary: ${0}\n", this._yearlySalary);
    }
}

public class PartTimeEmployee : Employee
{
    float _hourlyWage;
    public float HourlyWage { get { return _hourlyWage; } set { _hourlyWage = value; } }

    public PartTimeEmployee() : base("Part Time")
    {
        Console.WriteLine("And then the child class constructor is called...");
    }

    public void PartTimeEmployeeInfo()
    {
        Console.WriteLine("Hourly Wage: ${0}\n", this._hourlyWage);
    }
}