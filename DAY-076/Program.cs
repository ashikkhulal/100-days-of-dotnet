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
                Salary = 90000,
                Type = "Government Customer"
            };

            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            List<Customer> listCorporateCustomers = new List<Customer>();
            listCorporateCustomers.Add(customer4);
            listCorporateCustomers.Add(customer5);

            Console.WriteLine("\nAdding range of values to the listCustomers:");
            listCustomers.AddRange(listCorporateCustomers);
            foreach(Customer customer in listCustomers)
            {
                Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}, and Type = {3}", customer.Id, customer.Name, customer.Salary, customer.Type);
            }

            Console.WriteLine("\nGetting range of values from the listCustomers:");
            List<Customer> getCorporateCustomers = listCustomers.GetRange(3, 2);
            foreach (Customer customer in getCorporateCustomers)
            {
                Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}, and Type = {3}", customer.Id, customer.Name, customer.Salary, customer.Type);
            }

            List<Customer> listGovernmentCustomers = new List<Customer>();
            listGovernmentCustomers.Add(customer6);
            listGovernmentCustomers.Add(customer7);

            Console.WriteLine("\nInserting range of values to the listCustomers:");
            listCustomers.InsertRange(3, listGovernmentCustomers);
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}, and Type = {3}", customer.Id, customer.Name, customer.Salary, customer.Type);
            }

            Console.WriteLine("\nRemoving (range of) value(s) to the listCustomers:");
            //listCustomers.Remove(customer4);
            //listCustomers.RemoveAt(3);
            //listCustomers.RemoveAll(customer => customer.Type == "Corporate Customer");
            listCustomers.RemoveRange(3, 2);
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}, and Type = {3}", customer.Id, customer.Name, customer.Salary, customer.Type);
            }

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