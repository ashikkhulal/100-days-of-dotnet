using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            PartialCustomer C1 = new PartialCustomer();
            C1.FirstName = "Mary";
            C1.LastName = "Poppins";
            string fullName = C1.GetFullName();
            Console.WriteLine("Full name = {0}", fullName);
        }
    }
}