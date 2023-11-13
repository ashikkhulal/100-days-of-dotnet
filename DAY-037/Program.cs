using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Employee> employees = new List<Employee>();
        employees.Add(new Employee() { Id = 1001, Name = "John Doe", Salary = 80000, Experience = 8 });
        employees.Add(new Employee() { Id = 1002, Name = "Mary Jane", Salary = 65000, Experience = 6 });
        employees.Add(new Employee() { Id = 1003, Name = "Mike Hubert", Salary = 50000, Experience = 5 });
        employees.Add(new Employee() { Id = 1004, Name = "Chris Evans", Salary = 45000, Experience = 3 });
        employees.Add(new Employee() { Id = 1004, Name = "Angelina Jolie", Salary = 40000, Experience = 2 });

        Employee.PromoteEmployee(employees);
    }

}

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }

    public static void PromoteEmployee(List<Employee> employeeList)
    {
        foreach (Employee employee in employeeList) 
        {
            if (employee.Experience >= 5)
            {
                Console.WriteLine(employee.Name + " promoted!");
            }
        }
    }
}
