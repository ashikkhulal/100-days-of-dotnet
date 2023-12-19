using System;

namespace ConsoleApp
{
    //public delegate bool FindCustomerById(Customer cust);

    public class Program
    {
        public static void Main()
        {
            List<Customer> listCustomers = new List<Customer>()
            {
                new Customer() { Id = 1001, Name = "John Doe", Salary = 100000 },
                new Customer() { Id = 1002, Name = "Mary Jane", Salary = 120000 },
                new Customer() { Id = 1003, Name = "Jane Smith", Salary = 90000 }
            };

            //Func<Customer, string> selector = customer => "Id = "+ customer.Id + ", Name = " + customer.Name + ", & Salary = $" + customer.Salary;
            //IEnumerable<string> customersInfo = listCustomers.Select(selector);            
            IEnumerable<string> customersInfo = listCustomers.Select(customer => "Id = " + customer.Id + ", Name = " + customer.Name + ", & Salary = $" + customer.Salary);

            foreach (string customerInfo in customersInfo)
            {
                Console.WriteLine(customerInfo);
            }

            Func<int, int, string> funcSum = (firstNum, secondNum) => "Sum is: " + (firstNum + secondNum).ToString();
            string result = funcSum(10, 20);
            Console.WriteLine(result);
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}