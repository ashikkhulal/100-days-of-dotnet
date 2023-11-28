using System;
using System.Reflection;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            // Early binding
            Customer C1 = new Customer();
            string C1FullName = C1.GetFullName("John", "Doe");
            Console.WriteLine("Full Name = {0}", C1FullName);

            // Late binding
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            Type businessType = executingAssembly.GetType("ConsoleApp.Business");
            object businessInstance = Activator.CreateInstance(businessType);
            MethodInfo getMethodName = businessType.GetMethod("GetFullCompanyName");
            string[] parameters = new string[2];
            parameters[0] = "Apple";
            parameters[1] = "Inc.";
            string fullCompanyName = (string)getMethodName.Invoke(businessInstance, parameters);
            Console.WriteLine("Full Company Name = {0}", fullCompanyName);
        }
    }

    public class Customer
    {
        public string GetFullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
    }

    // Assuming Business class is not available at runtime.
    public class Business
    {
        public string GetFullCompanyName(string companyName, string type)
        {
            return companyName + " " + type;
        }
    }
}