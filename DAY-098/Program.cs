using System;

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

            // Step-2
            Predicate<Customer> customerPredicate = new Predicate<Customer>(FindCustomerById);

            // Step-3
            Customer customer1002 = listCustomers.Find(cust => FindCustomerById(cust));
            Console.WriteLine("Id = {0}, Name = {1}, and Salary = ${2}", customer1002.Id, customer1002.Name, customer1002.Salary);

            // Using Anonymous method

            Customer customer1002UsingAnynomousMethod = listCustomers.Find(delegate (Customer cust)
            {
                return cust.Id == 1002;
            });
            Console.WriteLine("Using Anonymous method:\nId = {0}, Name = {1}, and Salary = ${2}", customer1002UsingAnynomousMethod.Id, customer1002UsingAnynomousMethod.Name, customer1002UsingAnynomousMethod.Salary);

        }

        // Step-1
        public static bool FindCustomerById(Customer customer)
        {
            return customer.Id == 1002;  
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}