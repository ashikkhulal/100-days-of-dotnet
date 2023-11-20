using System;

public class Program
{
    public static void Main()
    {
        Customer[] customer = new Customer[4];
        customer[0] = new Customer()
        {
            Name = "John",
            Gender = Gender.Male
        };
        customer[1] = new Customer()
        {
            Name = "Mary",
            Gender = Gender.Female
        };
        customer[2] = new Customer()
        {
            Name = "Jill",
            Gender = Gender.Unknown
        };
        customer[3] = new Customer()
        {
            Name = "Jack",
        };

        foreach (Customer cust in customer)
        {
            Console.WriteLine("Name = {0}, and Gender = {1}", cust.Name, GetGender(cust.Gender));
        }
    }  
    
    public static string GetGender(Gender gender)
    {
        switch (gender)
        {
            case Gender.Unknown:
                return "Unknown";
            case Gender.Male:
                return "Male";
            case Gender.Female:
                return "Female";
            default:
                return "Invalid data detected";
        }
    }
}

public enum Gender
{
    Unknown,
    Male,
    Female
}

// 0 - Unknown
// 1 - Male
// 2 - Female

public class Customer
{
    public string Name { get; set; }
    public Gender Gender { get; set; }
}
