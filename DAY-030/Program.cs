using System;
using System.Reflection.Metadata;

public class Program
{
    public static void Main()
    {
        Customer customer = new Customer();
        customer.PrintCompanyInterfaceMethod();
        customer.PrintCustomerInterfaceMethod();
        customer.PrintCustomerInterfaceMethod("Hello");
        customer.PrintAdminInterfaceMethod();
        customer.PrintAdminClassMethod();

        ICustomer customer2 = new Customer();
        customer2.PrintCustomerInterfaceMethod();
    }
}

public class Customer : Admin, ICompany, IAdmin
{
    public void PrintCompanyInterfaceMethod()
    {
        Console.WriteLine("Implementation of Company interface");
    }

    public void PrintCustomerInterfaceMethod()
    {
        Console.WriteLine("Implementation of Customer interface; inherited from Company interface");
    }

    public void PrintCustomerInterfaceMethod(string s) 
    {
        Console.WriteLine(s);
    }

    public void PrintAdminInterfaceMethod()
    {
        Console.WriteLine("Implementation of Admin interface");
    }

    public new void PrintAdminClassMethod()
    {
        Console.WriteLine("Implementation of Admin class; encapsulation...");
        Admin admin = new Admin();
        admin.PrintAdminClassMethod();
    }

}

interface ICompany : ICustomer
{
    void PrintCompanyInterfaceMethod() { }
}

public interface ICustomer
{
    void PrintCustomerInterfaceMethod() { }
}

interface IAdmin
{
    void PrintAdminInterfaceMethod() { }
}

public class Admin
{
    public void PrintAdminClassMethod()
    {
        Console.WriteLine("Implementation of Admin class");
    }
}