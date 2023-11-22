using System;
using System.Reflection;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            Customer c1 = new Customer();

            Type T = Type.GetType("ConsoleApp.Customer");
            //Type T = typeof(Customer);
            //Type T = c1.GetType();

            Console.WriteLine("Fully qualified name = {0}", T.FullName);
            Console.WriteLine("Only class name = {0}", T.Name);
            Console.WriteLine("Namespace = {0}", T.Namespace);

            FieldInfo[] fields = T.GetFields();
            Console.WriteLine($"---------Fields in {T.Name} Class---------");
            foreach (FieldInfo field in fields)
            {
                Console.WriteLine("Field Name = {0}, Type = {1}", field.Name, field.FieldType);
            }

            PropertyInfo[] properties = T.GetProperties();
            Console.WriteLine($"---------Properties in {T.Name} Class---------");
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine("Property Name = {0}, Type = {1}", property.Name, property.PropertyType);
            }

            MethodInfo[] methods = T.GetMethods();
            Console.WriteLine($"---------Methods in {T.Name} Class---------");
            foreach( MethodInfo method in methods)
            {
                Console.WriteLine("Method name = {0}, Return Type = {1}", method.Name, method.ReturnType.Name);
            }

            ConstructorInfo[] constructors = T.GetConstructors();
            Console.WriteLine($"---------Constructors in {T.Name} Class---------");
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine("Constructor name = {0}", constructor.ToString());
            }

        }
    }

    public class Customer
    {
        private int _id;
        private string _name;

        public int Id { get { return _id; } set { _id = value;  } }
        public string Name { get { return _name; } set { _name = value; } }

        public Customer()
        {
            Console.WriteLine("Hello from Customer constructor!");
        }

        public void PrintName()
        {
            Console.WriteLine("Name = {1}", Name);
        }

        public void PrintFullInfo()
        {
            Console.WriteLine("Id = {0}, Name = {1}", Id, Name);
        }
    }
}