using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            FullCustomer C1 = new FullCustomer();
            C1.FirstName = "John";
            C1.LastName = "Doe";
            string fullName1 = C1.GetFullName();
            Console.WriteLine("Full name = {0}", fullName1);

            PartialCustomer C2 = new PartialCustomer();
            C2.FirstName = "Mary";
            C2.LastName = "Poppins";
            string fullName2 = C2.GetFullName();
            Console.WriteLine("Full name = {0}", fullName2);
        }
    }
}