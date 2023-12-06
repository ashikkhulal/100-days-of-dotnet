using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            Company company = new Company();
            Console.WriteLine("Name of employee with id 2: {0}", company[2]);
            Console.WriteLine("Name of employee with id 5: {0}", company[5]);
            Console.WriteLine("Name of employee with id 10: {0}", company[10]);

            company[5] = "Sajjan Raj Vaidya";
            Console.WriteLine("New name of employee with id 5: {0}", company[5]);
        }
    }
}