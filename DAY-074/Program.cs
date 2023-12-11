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

            Customer[] customers = new Customer[2];
            customers[0] = customer1;
            customers[1] = customer2;

            List<Customer> listCustomer = new List<Customer>(2);
            listCustomer.Add(customer1);
            listCustomer.Add(customer2);
            Console.WriteLine("List capacity is {0} && count is {1}", listCustomer.Capacity, listCustomer.Count);
            listCustomer.Add(customer3);
            listCustomer.Add(customer5);
            Console.WriteLine("Now, the list capacity is {0} && count is {1}", listCustomer.Capacity, listCustomer.Count);
            

            //Customer Cust1 = listCustomer[0];
            //Console.WriteLine("Id = {0}, Name = {1}, and Salary = {2}", Cust1.Id, Cust1.Name, Cust1.Salary);

            foreach (Customer customer in listCustomer)
            {
                Console.WriteLine("Id = {0}, Name = {1}, and Salary = {2}", customer.Id, customer.Name, customer.Salary);
            }

            listCustomer.Insert(3, customer4);
            Console.WriteLine("Now, the list capacity is {0} && count is {1}", listCustomer.Capacity, listCustomer.Count);

            for (int i = 0; i < listCustomer.Count; i++)
            {
                Customer customer = listCustomer[i];
                Console.WriteLine("Id = {0}, Name = {1}, and Salary = {2}", customer.Id, customer.Name, customer.Salary);
            }

            Console.WriteLine("Index of customer4 is {0}", listCustomer.IndexOf(customer4));
            Console.WriteLine("Index of customer2 is {0}", listCustomer.IndexOf(customer2));
            Console.WriteLine("Index of customer2 is {0} from index 0", listCustomer.IndexOf(customer2, 0));
            Console.WriteLine("Index of customer2 is {0} from index 2", listCustomer.IndexOf(customer2, 2));
            Console.WriteLine("Index of customer5 is {0} from index 2 within 4 counts", listCustomer.IndexOf(customer5, 0, 5));
            Console.WriteLine("Index of customer5 is {0} from index 2 within 2 counts", listCustomer.IndexOf(customer5, 3, 2));

            PremiumCustomer premiumCustomer = new PremiumCustomer();

            listCustomer.Add(premiumCustomer);

        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }

    public class PremiumCustomer : Customer
    {
        
    }
}