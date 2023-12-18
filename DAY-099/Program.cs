using System;
using System.Linq;

namespace ConsoleApp
{
    //public delegate bool FindCustomerById(Customer cust);

    public class Program
    {
        public static void Main()
        {
            List<Customer> listCustomers = new List<Customer>()
            {
                new Customer() { Id = 1001, Name = "John Doe", Salary = 100000 },
                new Customer() { Id = 1002, Name = "Mary Jane", Salary = 120000 },
                new Customer() { Id = 1003, Name = "Jane Smith", Salary = 90000 }
            };

            // Using Anonymous method
            Customer customer1002UsingAnynomousMethod = listCustomers.Find(delegate (Customer cust) { return cust.Id == 1002; });
            Console.WriteLine("Using Anonymous method:\nId = {0}, Name = {1}, and Salary = ${2}", customer1002UsingAnynomousMethod.Id, customer1002UsingAnynomousMethod.Name, customer1002UsingAnynomousMethod.Salary);

            // Using Lambda expression
            //Customer customer1002UsingLamdaExpression = listCustomers.Find(cust => cust.Id == 1002);
            Customer customer1002UsingLamdaExpression = listCustomers.Find((Customer cust) => cust.Id == 1002);
            Console.WriteLine("Using lamda expression:\nId = {0}, Name = {1}, and Salary = ${2}", customer1002UsingLamdaExpression.Id, customer1002UsingLamdaExpression.Name, customer1002UsingLamdaExpression.Salary);

            int count = listCustomers.Count();
            int countNameStartsWithJ = listCustomers.Count(x => x.Name.StartsWith("J"));
            Console.WriteLine("# of customers whose name starts with J: {0}", countNameStartsWithJ);
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}