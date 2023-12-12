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

            List<Customer> listCustomers = new List<Customer>();
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

            Console.WriteLine("Before sorting:");
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine("Id = {0} Name = {1} Salary = {2} & Type = {3}", customer.Id, customer.Name, customer.Salary, customer.Type);
            }

            Console.WriteLine("\n(Approach 1) After sorting using Comparison delegate:");
            Comparison<Customer> comparingCustomer = new Comparison<Customer>(CompareCustomer);
            listCustomers.Sort(comparingCustomer);
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine("Id = {0} Name = {1} Salary = {2} & Type = {3}", customer.Id, customer.Name, customer.Salary, customer.Type);
            }

            Console.WriteLine("\n(Approach 2) After sorting using Comparison delegate:");
            listCustomers.Sort(delegate(Customer c1, Customer c2) { return c1.Type.CompareTo(c2.Type); });
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine("Id = {0} Name = {1} Salary = {2} & Type = {3}", customer.Id, customer.Name, customer.Salary, customer.Type);
            }

            Console.WriteLine("\n(Approach 3) After sorting using Comparison delegate:");
            listCustomers.Sort((x, y) => x.Type.CompareTo(y.Type));
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine("Id = {0} Name = {1} Salary = {2} & Type = {3}", customer.Id, customer.Name, customer.Salary, customer.Type);
            }
        }
        private static int CompareCustomer(Customer x, Customer y)
        {
            return x.Type.CompareTo(y.Type);
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