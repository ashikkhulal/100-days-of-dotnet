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

            Stack<Customer> customersStack = new Stack<Customer>();
            customersStack.Push(customer1);
            customersStack.Push(customer2);
            customersStack.Push(customer3);
            customersStack.Push(customer4);
            customersStack.Push(customer5);

            Console.WriteLine("Initial customersStack count: {0}", customersStack.Count);
            Console.WriteLine("Popping first time from the top of customersStack:");
            Customer c5 = customersStack.Pop();
            Console.WriteLine("Customer Id = {0}, Customer Name = {1} & Customer Gender = {1}", c5.Id, c5.Name, c5.Gender);
            Console.WriteLine("After popping, customersStack count: {0}", customersStack.Count);
            Console.WriteLine("\nRemaining objects in customersStack:");
            foreach (Customer cust in customersStack)
            {
                Console.WriteLine("Customer Id = {0}, Customer Name = {1} & Customer Gender = {1}", cust.Id, cust.Name, cust.Gender);
            }

            Console.WriteLine("\nPopping second time from the top of customersStack:");
            Customer c4 = customersStack.Pop();
            Console.WriteLine("Customer Id = {0}, Customer Name = {1} & Customer Gender = {1}", c4.Id, c4.Name, c4.Gender);
            Console.WriteLine("After popping, customersStack count: {0}", customersStack.Count);

            Console.WriteLine("\nPopping third time from the top of customersStack:");
            Customer c3 = customersStack.Pop();
            Console.WriteLine("Customer Id = {0}, Customer Name = {1} & Customer Gender = {1}", c3.Id, c3.Name, c3.Gender);
            Console.WriteLine("After popping, customersStack count: {0}", customersStack.Count);

            Console.WriteLine("\nPopping fourth time from the top of customersStack:");
            Customer c2 = customersStack.Pop();
            Console.WriteLine("Customer Id = {0}, Customer Name = {1} & Customer Gender = {1}", c2.Id, c2.Name, c2.Gender);
            Console.WriteLine("After popping, customersStack count: {0}", customersStack.Count);

            Console.WriteLine("\nPopping fifth time from the top of customersStack:");
            Customer c1 = customersStack.Pop();
            Console.WriteLine("Customer Id = {0}, Customer Name = {1} & Customer Gender = {1}", c1.Id, c1.Name, c1.Gender);
            Console.WriteLine("After popping, customersStack count: {0}", customersStack.Count);

            customersStack.Push(customer1);
            customersStack.Push(customer2);
            customersStack.Push(customer3);
            customersStack.Push(customer4);
            customersStack.Push(customer5);
            Console.WriteLine("\nNew initial customersStack count: {0}", customersStack.Count);

            Console.WriteLine("Calling Peek() method to fetch last added (at top) object w/o removing it from customersStack:");
            Customer c = customersStack.Peek();
            Console.WriteLine("Customer Id = {0}, Customer Name = {1} & Customer Gender = {1}", c.Id, c.Name, c.Gender);
            Console.WriteLine("After peeking, customersStack count: {0}\n", customersStack.Count);

            if (customersStack.Contains(customer5))
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