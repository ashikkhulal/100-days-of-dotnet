using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            Company company = new Company();
            Console.WriteLine("Name of employee with id 2: {0}", company[2]);
            Console.WriteLine("Total # of male employees is: {0}", company["Male"]);
            Console.WriteLine("Total # of female employees is: {0}", company["Female"]);

            Console.WriteLine("Name of employee with id 8: {0} & gender is: {1}", company[8], company[8, 'Y']);
            
            company[8] = "Angelina Jolie";
            company[8, "Male"] = "Female";
            Console.WriteLine("New name of employee with id 8: {0} & gender is: {1}", company[8], company[8, 'Y']);
            Console.WriteLine("Total # of male employees is: {0}", company["Male"]);
            Console.WriteLine("Total # of female employees is: {0}", company["Female"]);

        }
    }
}