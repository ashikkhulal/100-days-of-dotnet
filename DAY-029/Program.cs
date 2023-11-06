using System;

public class Program
{
    public static void Main()
    {
        int i = 0;

        if (i == 10)
        {
            int j = 20;
            Customer customer = new Customer();
            customer.Id = 1001;
            customer.Name = "John";
        }

        int k = 100;
        int l = k;
        l = l + 1;

        Console.WriteLine("k = {0} && l = {1}", k, l);

        Customer customer1 = new Customer();
        customer1.Id = 1001;
        customer1.Name = "John";

        Customer customer2 = customer1;

        customer2.Name = "Mary";

        Console.WriteLine("customer1.Name = {0} && customer2.Name = {1}", customer1.Name, customer2.Name);
    }
}

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }


    public Customer() 
    {
    }
    ~Customer() 
    {
    }
}