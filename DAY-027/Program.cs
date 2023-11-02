using System;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        Student S1 = new Student();
        S1.Id = 1;
        S1.Name = "Ashik Khulal"; ;
        S1.City = "Houston";
        S1.Email = "ashik@example.com";

        Console.WriteLine("ID = {0}, Name = {1}, PassMark = {2}, and City = {3}", S1.Id, S1.Name, S1.PassMark, S1.City);

        Student S2 = new Student();
        S2.Id = 2;
        S2.Name = "Arun Khulal";
        S2.City = "Kathmandu";
        S2.Email = "arun@example.com";

        Console.WriteLine("ID = {0}, Name = {1}, PassMark = {2}, and City = {3}", S2.Id, S2.Name, S2.PassMark, S1.City);

    }
}

public class Student
{
    private int _id;
    private string _name;
    private int _passMark = 35;
    private string _email;

    // Read and write properties
    public int Id
    {
        set 
        {
            if (value <= 0)
            {
                throw new Exception("Id cannot be zero or negative.");
            }
            this._id = value;
        }
        get { return this._id; }
    }

    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Name cannot be null or empty.");
            }
            this._name = value;
        }

        get { return string.IsNullOrEmpty(this._name) ? "No Name Provided" : this._name; }
    }

    public int PassMark { get { return this._passMark; } }  // Read-only property

    public string City { get; set; }   // Auto-implemented property
    public string Email { set { this._email = value; } }  // Write-only property
    
}