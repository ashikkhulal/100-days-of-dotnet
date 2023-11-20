using System;

public class Program
{
    public static void Main()
    {
        Customer[] customer = new Customer[3];
        customer[0] = new Customer()
        {
            Name = "John",
            Gender = 1
        };
        customer[1] = new Customer()
        {
            Name = "Mary",
            Gender = 2
        };
        customer[2] = new Customer()
        {
            Name = "Jill",
            Gender = 0
        };

        foreach (Customer cust in customer)
        {
            Console.WriteLine("Name = {0}, and Gender = {1}", cust.Name, GetGender(cust.Gender));
        }
    }  
    
    public static string GetGender(int gender)
    {
        switch (gender)
        {
            case 0:
                return "Unknown";
            case 1:
                return "Male";
            case 2:
                return "Female";
            default:
                return "Invalid data detected";
        }
    }
}

// 0 - Unknown
// 1 - Male
// 2 - Female

public class Customer
{
    public string Name { get; set; }
    public int Gender { get; set; }
}
