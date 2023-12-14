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

            Console.WriteLine("\nInitial customersQueue count: {0}", customersQueue.Count);
            Console.WriteLine("Dequeuing first object in customersQueue:");
            Customer c1 = customersQueue.Dequeue();
            Console.WriteLine("Customer Id = {0}, Customer Name = {1} & Customer Gender = {1}", c1.Id, c1.Name, c1.Gender);

            Console.WriteLine("\nAfter dequeuing, customersQueue count: {0}", customersQueue.Count);
            Console.WriteLine("Remaining objects in customersQueue:");
            foreach (Customer cust in customersQueue)
            {
                Console.WriteLine("Customer Id = {0}, Customer Name = {1} & Customer Gender = {1}", cust.Id, cust.Name, cust.Gender);
            }

            Console.WriteLine("\nDequeuing second object in customersQueue:");
            Customer c2 = customersQueue.Dequeue();
            Console.WriteLine("Customer Id = {0}, Customer Name = {1} & Customer Gender = {1}", c2.Id, c2.Name, c2.Gender);
            Console.WriteLine("After dequeuing, customersQueue count: {0}", customersQueue.Count);

            Console.WriteLine("\nDequeuing third object in customersQueue:");
            Customer c3 = customersQueue.Dequeue();
            Console.WriteLine("Customer Id = {0}, Customer Name = {1} & Customer Gender = {1}", c3.Id, c3.Name, c3.Gender);
            Console.WriteLine("After dequeuing, customersQueue count: {0}", customersQueue.Count);

            Console.WriteLine("\nDequeuing fourth object in customersQueue:");
            Customer c4 = customersQueue.Dequeue();
            Console.WriteLine("Customer Id = {0}, Customer Name = {1} & Customer Gender = {1}", c4.Id, c4.Name, c4.Gender);
            Console.WriteLine("After dequeuing, customersQueue count: {0}", customersQueue.Count);

            Console.WriteLine("\nDequeuing fifth object in customersQueue:");
            Customer c5 = customersQueue.Dequeue();
            Console.WriteLine("Customer Id = {0}, Customer Name = {1} & Customer Gender = {1}", c5.Id, c5.Name, c5.Gender);
            Console.WriteLine("After dequeuing, customersQueue count: {0}", customersQueue.Count);

            customersQueue.Enqueue(customer1);
            customersQueue.Enqueue(customer2);
            customersQueue.Enqueue(customer3);
            customersQueue.Enqueue(customer4);
            customersQueue.Enqueue(customer5);

            Console.WriteLine("\nNew initial customersQueue count: {0}", customersQueue.Count);
            Console.WriteLine("Calling Peek() method to fetch first object w/o removing it from customersQueue:");
            Customer c = customersQueue.Peek();
            Console.WriteLine("Customer Id = {0}, Customer Name = {1} & Customer Gender = {1}", c.Id, c.Name, c.Gender);

            if (customersQueue.Contains(customer5))
            {
                Console.WriteLine("Object customer5 exists");
            }
            else
            {
                Console.WriteLine("Object customer5 does not exist");
            }

        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }

}