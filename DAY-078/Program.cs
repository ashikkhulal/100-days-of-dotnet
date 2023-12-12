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

            //Console.WriteLine("\nAfter sorting for salary using IComparable:");
            //listCustomers.Sort();
            //foreach (Customer customer in listCustomers)
            //{
            //    Console.WriteLine("Id = {0} Name = {1} Salary = {2} & Type = {3}", customer.Id, customer.Name, customer.Salary, customer.Type);
            //}

            //Console.WriteLine("\nAfter sorting for salary in reverse order using IComparable:");
            //listCustomers.Reverse();
            //foreach (Customer customer in listCustomers)
            //{
            //    Console.WriteLine("Id = {0} Name = {1} Salary = {2} & Type = {3}", customer.Id, customer.Name, customer.Salary, customer.Type);
            //}

            Console.WriteLine("\nAfter sorting for Name using IComparable:");
            listCustomers.Sort();
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine("Id = {0} Name = {1} Salary = {2} & Type = {3}", customer.Id, customer.Name, customer.Salary, customer.Type);
            }

            Console.WriteLine("\nAfter sorting for Name using IComparer:");
            SortByName sortByName = new SortByName();
            listCustomers.Sort(sortByName);
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine("Id = {0} Name = {1} Salary = {2} & Type = {3}", customer.Id, customer.Name, customer.Salary, customer.Type);
            }

            Console.WriteLine("\nAfter sorting for salary using IComparer:");
            SortBySalary sortBySalary = new SortBySalary();
            listCustomers.Sort(sortBySalary);
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine("Id = {0} Name = {1} Salary = {2} & Type = {3}", customer.Id, customer.Name, customer.Salary, customer.Type);
            }

        }
    }

    public class Customer : IComparable<Customer>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; }

        public int CompareTo(Customer other)
        {
            //if (this.Salary > other.Salary)
            //{
            //    return 1;
            //}
            //else if (this.Salary < other.Salary)
            //{
            //    return -1;
            //}
            //else
            //{
            //    return 0;
            //}

            //return this.Salary.CompareTo(other.Salary);
            return this.Name.CompareTo(other.Name);
        }
    }

    public class SortByName : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

    public class SortBySalary : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Salary.CompareTo(y.Salary);
        }
    }
}