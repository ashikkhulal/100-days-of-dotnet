using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            Customer customer1 = new Customer()
            {
                Id = 1001,
                Name = "John Doe",
                Salary = 100000
            };

            Customer customer2 = new Customer()
            {
                Id = 1002,
                Name = "Mary Jane",
                Salary = 120000
            };

            Customer customer3 = new Customer()
            {
                Id = 1003,
                Name = "Jane Smith",
                Salary = 80000
            };

            Dictionary<int, Customer> customerDictonary = new Dictionary<int, Customer>();
            customerDictonary.Add(customer1.Id, customer1);
            customerDictonary.Add(customer2.Id, customer2);
            customerDictonary.Add(customer3.Id, customer3);

            Customer customer1003 = customerDictonary[1003];

            Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", customer1003.Id, customer1003.Name, customer1003.Salary);

            foreach (KeyValuePair<int, Customer> customerKeyValuePair in customerDictonary)
            //foreach (var customerKeyValuePair in customerDictonary)
            {
                Console.WriteLine("Id = {0}", customerKeyValuePair.Key);
                Customer customer = customerKeyValuePair.Value;
                Console.WriteLine("Name = {0}, Salary = {1}", customer.Name, customer.Salary);
                Console.WriteLine("----------------------------------------------------------");
            }

            foreach (int key in customerDictonary.Keys)
            {
                Console.WriteLine("Id = {0}", key);
            }

            foreach (Customer value in customerDictonary.Values)
            {
                Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", value.Id, value.Name, value.Salary);
            }
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}