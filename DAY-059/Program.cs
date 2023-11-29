using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            Customer C1 = new Customer();
            string str1 = C1.ToString();
            Console.WriteLine(str1);
            string str2 = Convert.ToString(C1);
            Console.WriteLine(str2);

            Customer C2 = null;
            string str3 = C2.ToString();    // Will cause null reference exception
            Console.WriteLine(str3);
            string str4 = Convert.ToString(C2);
            Console.WriteLine(str4);

        }
    }

    public class Customer
    {
        public string Name { get; set; }
    }
}