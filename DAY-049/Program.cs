using System;

public class Program
{
    public static void Main()
    {
        Customer customer = new Customer();
        //customer._id = 1001;
        //customer.Id = 1002;
        //customer.FirstName = "John";
        customer.LastName = "Doe";
        Console.WriteLine(customer.GetFullInfo());
    }  
}

public class Customer
{
    #region Fields
    private int _id;
    private string _firstName;
    private string _lastName;
    private string _email;
    #endregion

    #region Properties
    protected int Id { get { return _id;} set { _id = value;} }
    protected string FirstName { get { return _firstName;} set { _firstName = value;} }
    public string LastName { get { return _lastName;} set { _lastName = value;} }
    #endregion

    #region Methods
    public string GetFullInfo()
    {
        string info = $"Id = {this._id}, Name = {this._firstName} {this._lastName}";
        return info;
    }
    #endregion
}

public class CorporateCustomer : Customer
{
    public void PrintCorporateCustomerInfo()
    {
        CorporateCustomer corp = new CorporateCustomer();
        corp.Id = 1002;

        base.FirstName = "Jim";
    }
}
