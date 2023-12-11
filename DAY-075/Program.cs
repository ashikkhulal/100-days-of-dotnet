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

            Customer customer4 = new Customer()
            {
                Id = 1004,
                Name = "Jack Ryan",
                Salary = 90000
            };

            Customer customer5 = new Customer()
            {
                Id = 1005,
                Name = "Jill Johns",
                Salary = 70000
            };

            List<Customer> listCustomer = new List<Customer>(5);
            listCustomer.Add(customer1);
            listCustomer.Add(customer2);
            listCustomer.Add(customer3);
            listCustomer.Add(customer4);
            listCustomer.Add(customer5);
            
            if(listCustomer.Contains(customer3))
            {
                Console.WriteLine("customer3 object exists in the list.");
            }
            else
            {
                Console.WriteLine("customer3 object does not exist in the list.");
            }

            if (listCustomer.Exists(customer => customer.Name.StartsWith("J")))
            {
                Console.WriteLine("Customer of name starting with J exists in the list.");
            }
            
            if (!listCustomer.Exists(customer => customer.Name.StartsWith("Z")))
            {
                Console.WriteLine("Customer of name starting with Z does not exist in the list.");
            }

            Customer salaryGreaterThan90K = listCustomer.Find(customer => customer.Salary > 90000);
            Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", salaryGreaterThan90K.Id, salaryGreaterThan90K.Name, salaryGreaterThan90K.Salary);

            Customer salaryGreaterThan90KLast = listCustomer.FindLast(customer => customer.Salary > 90000);
            Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", salaryGreaterThan90KLast.Id, salaryGreaterThan90KLast.Name, salaryGreaterThan90KLast.Salary);

            List<Customer>? salaryGreaterThan90KAll = listCustomer.FindAll(customer => customer.Salary > 80000);
            foreach (Customer cust in salaryGreaterThan90KAll)
            {
                Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", cust.Id, cust.Name, cust.Salary);
            }

            int index1 = listCustomer.FindIndex(cust => cust.Salary > 90000);
            Console.WriteLine("Index of customer with Salary > 90K is: {0}", index1);

            int index2 = listCustomer.FindIndex(1, cust => cust.Salary > 90000);
            Console.WriteLine("Index of customer with Salary > 90K with start index at 1 is: {0}", index2);

            int index3 = listCustomer.FindIndex(2, 3, cust => cust.Salary > 90000);
            Console.WriteLine("Index of customer with Salary > 90K with start index at 2 w/ three count is: {0}", index3);

            int index4 = listCustomer.FindLastIndex(cust => cust.Salary > 80000);
            Console.WriteLine("Last matching index of customer with Salary > 80K is: {0}", index4);

            Console.WriteLine("Converting Array to List:");
            Customer[] customerArray = new Customer[3];
            customerArray[0] = customer1;
            customerArray[1] = customer2;
            customerArray[2] = customer3;
            List<Customer> arrayToList = customerArray.ToList();
            foreach (Customer c in arrayToList)
            {
                Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", c.Id, c.Name, c.Salary);
            }

            Console.WriteLine("Converting List to Array:");
            Customer[] listToArray = listCustomer.ToArray();
            foreach (Customer c in listToArray)
            {
                Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", c.Id, c.Name, c.Salary);
            }

            Console.WriteLine("Converting List to Dictionary:");
            Dictionary<int, Customer> listToDictonary = listCustomer.ToDictionary(x => x.Id);
            foreach (KeyValuePair<int, Customer> kvp in listToDictonary)
            {
                Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", kvp.Value.Id, kvp.Value.Name, kvp.Value.Salary);
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