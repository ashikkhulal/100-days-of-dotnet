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

            Customer customer;

            if (customerDictonary.TryGetValue(1003, out customer))
            {
                Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", customer.Id, customer.Name, customer.Salary);
            }
            else
            {
                Console.WriteLine("Key does not exists");
            }

            Console.WriteLine("Total items in customerDictonary = {0}", customerDictonary.Count);
            Console.WriteLine("Total items in customerDictonary (using Count method from Linq class) = {0}", customerDictonary.Count());
            Console.WriteLine("Total items in customerDictonary whose Salary is greater than 90K = {0}", customerDictonary.Count(kvp => kvp.Value.Salary > 90000));

            customerDictonary.Remove(110);

            //customerDictonary.Clear();

            Customer[] customers = new Customer[3];
            customers[0] = customer1;
            customers[1] = customer2;
            customers[2] = customer3;

            Dictionary<int, Customer> dictionaryFromArray = customers.ToDictionary(cust => cust.Id, cust => cust);

            List<Customer> customersList = new List<Customer>();
            customersList.Add(customer1);
            customersList.Add(customer2);
            customersList.Add(customer3);

            Dictionary<int, Customer> dictionaryFromList = customersList.ToDictionary(cust => cust.Id, cust => cust);
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}