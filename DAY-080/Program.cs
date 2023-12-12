using System;
using System.Collections.ObjectModel;

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
                Salary = 100000,
                Type = "Retail Customer"
            };

            Customer customer2 = new Customer()
            {
                Id = 1002,
                Name = "Mary Jane",
                Salary = 120000,
                Type = "Retail Customer"
            };

            Customer customer3 = new Customer()
            {
                Id = 1003,
                Name = "Jane Smith",
                Salary = 80000,
                Type = "Retail Customer"
            };

            Customer customer4 = new Customer()
            {
                Id = 1004,
                Name = "Jack Ryan",
                Salary = 90000,
                Type = "Corporate Customer"
            };

            Customer customer5 = new Customer()
            {
                Id = 1005,
                Name = "Jill Johns",
                Salary = 70000,
                Type = "Corporate Customer"
            };

            Customer customer6 = new Customer()
            {
                Id = 1006,
                Name = "Thomas Adams",
                Salary = 80000,
                Type = "Government Customer"
            };

            Customer customer7 = new Customer()
            {
                Id = 1007,
                Name = "George Washington",
                Salary = 95000,
                Type = "Government Customer"
            };

            List<Customer> listCustomers = new List<Customer>(50);
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            List<Customer> listCorporateCustomers = new List<Customer>();
            listCorporateCustomers.Add(customer4);
            listCorporateCustomers.Add(customer5);
            listCustomers.AddRange(listCorporateCustomers);

            List<Customer> listGovernmentCustomers = new List<Customer>();
            listGovernmentCustomers.Add(customer6);
            listGovernmentCustomers.Add(customer7);
            listCustomers.AddRange(listGovernmentCustomers);

            Console.WriteLine("Are salaries of all customers is greater than 60K: {0}", listCustomers.TrueForAll(x => x.Salary > 60000));

            ReadOnlyCollection<Customer> readOnlyListCustomers = listCustomers.AsReadOnly();
            foreach (Customer customer in readOnlyListCustomers)
            {
                Console.WriteLine("Id = {0} Name = {1} Salary = {2} & Type = {3}", customer.Id, customer.Name, customer.Salary, customer.Type);
            }

            Console.WriteLine("Capacity of listCustomer before trimming: {0}", listCustomers.Capacity);
            listCustomers.TrimExcess();
            Console.WriteLine("Capacity of listCustomer after trimming: {0}", listCustomers.Capacity);
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; }
    }

}