using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            int number = 10;
            Console.WriteLine(number.ToString());

            Customer C1 = new Customer();
            C1.Name = "John Doe";
            C1.Address = "123 Express Way, Texas, USA, 12345";

            //Console.WriteLine(C1.ToString()); //Without override of ToString(), it will print Program.Customer
            Console.WriteLine(C1.ToString());
            //Console.WriteLine(Convert.ToString(C1));
            
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"Name = {Name}\nAddress = {Address}";
        }
    }
}