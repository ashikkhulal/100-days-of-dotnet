using System;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        Student S1 = new Student();
        S1.SetId(-10);
        S1.SetName(null);

        Console.WriteLine("ID = {0}, Name = {1}, and PassMark = {2}", S1.GetId(), S1.GetName(), S1.GetPassMark());

        Student S2 = new Student();
        S2.SetId(10);
        S2.SetName("Ashik Khulal");

        Console.WriteLine("ID = {0}, Name = {1}, and PassMark = {2{", S2.GetId(), S2.GetName(), S2.GetPassMark());

    }
}

public class Student
{
    private int _id;
    private string _name; 
    private int _passMark = 35;

    public void SetId (int id)
    {
        if (id < 0)
        {
            throw new Exception("Id cannot be less than zero.");
        }

        this._id = id;
    }

    public int GetId()
    {
        return this._id;
    }

    public void SetName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new Exception("Name cannot be null or empty.");
        }

        this._name = name;
    }

    public string GetName()
    {
        return string.IsNullOrEmpty(this._name) ? "No Name Provided" : this._name;
    }

    public int GetPassMark()
    {
        return this._passMark;
    }
}