using System;

namespace ConsoleApp
{
    public class Company
    {
        private List<Employee> listEmployees;

        public Company()
        {
            listEmployees = new List<Employee>();
            listEmployees.Add(new Employee() { EmployeeId = 1, Name =  "John Doe", Gender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 2, Name =  "Mary Jane", Gender = "Female" });
            listEmployees.Add(new Employee() { EmployeeId = 3, Name =  "Ron Hopkins", Gender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 4, Name =  "Jill Doe", Gender = "Female" });
            listEmployees.Add(new Employee() { EmployeeId = 5, Name =  "Sudish Thapa", Gender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 6, Name =  "Hari Raut", Gender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 7, Name =  "Sushmita Katuwal", Gender = "Female" });
            listEmployees.Add(new Employee() { EmployeeId = 8, Name =  "Arun Khulal", Gender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 9, Name =  "Anisha Khulal", Gender = "Female" });
            listEmployees.Add(new Employee() { EmployeeId = 10, Name =  "Mark Johnson", Gender = "Male" });
        }

        public string this[int employeeId]
        {
            get
            {
                return listEmployees.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name;
            }
            set
            {
                listEmployees.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name = value;
            }
        }

        public string this[string gender]
        {
            get
            {
                return listEmployees.Count(emp => emp.Gender == gender).ToString();
            }
        }

        public string this[int employeeId, char getGender]
        {
            get
            {
                if (getGender == 'Y' ||  getGender == 'y')
                {
                    return listEmployees.FirstOrDefault(emp => emp.EmployeeId == employeeId).Gender;
                }
                else
                {
                    return listEmployees.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name;
                }
            }
            
        }

        public string this[int employeeId, string gender]
        {
            set
            {
                listEmployees.FirstOrDefault(emp => emp.EmployeeId == employeeId).Gender = value;
            }
        }
    }

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
    }
}
