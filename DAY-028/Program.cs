using System;

public class Program
{
    public static void Main()
    {
        Customer customer = new Customer();
        customer.ID = 1;
        customer.Name = "John Doe";
        customer.PrintDetails();

        Customer customer2 = new Customer(2, "Jen Doe");
        customer2.PrintDetails();

        Customer customer3 = new Customer
        {
            ID = 3,
            Name = "Jill Doe"
        };
        customer3.PrintDetails();
    }
}

public struct Customer
{
    private int _id;
    private string _name;

    public int ID { get { return _id; } set { this._id = value; } }
    public string Name { get { return _name;} set { this._name = value; } }

    public Customer(int id, string name)
    {
        this._id = id + 1000;
        this._name = "Mr./ Mrs. " + name;
    }

    public void PrintDetails()
    {
        Console.WriteLine("Id = {0}, Name = {1}", this._id, this._name);
    }
}