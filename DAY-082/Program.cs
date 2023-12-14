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
                Gender = "Male"
            };

            Customer customer2 = new Customer()
            {
                Id = 1002,
                Name = "Mary Jane",
                Gender = "Female"
            };

            Customer customer3 = new Customer()
            {
                Id = 1003,
                Name = "Jane Smith",
                Gender = "Female"
            };

            Customer customer4 = new Customer()
            {
                Id = 1004,
                Name = "Jack Ryan",
                Gender = "Male"
            };

            Customer customer5 = new Customer()
            {
                Id = 1005,
                Name = "Jill Johns",
                Gender = "Female"
            };

            Queue<Customer> customersQueue = new Queue<Customer>();
            customersQueue.Enqueue(customer1);
            customersQueue.Enqueue(customer2);
            customersQueue.Enqueue(customer3);
            customersQueue.Enqueue(customer4);
            customersQueue.Enqueue(customer5);

            Console.WriteLine("Initial customersQueue count: {0}", customersQueue.Count);
            Console.WriteLine("Dequeuing first object in customersQueue:");
            Customer fromCustomersQueue = customersQueue.Dequeue();
            Console.WriteLine("Customer Id = {0}, Customer Name = {1} & Customer Gender = {1}", fromCustomersQueue.Id, fromCustomersQueue.Name, fromCustomersQueue.Gender);

            Console.WriteLine("\nAfter dequeuing, customersQueue count: {0}", customersQueue.Count);
            Console.WriteLine("Remaining objects in customersQueue:");
            foreach (Customer cust in customersQueue)
            {
                Console.WriteLine("Customer Id = {0}, Customer Name = {1} & Customer Gender = {1}", cust.Id, cust.Name, cust.Gender);
            }

            // Continue from 4:12
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }

}