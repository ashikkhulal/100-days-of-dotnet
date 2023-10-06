using System;

class Car
{
    string _make;
    string _model;
    string _year;

    public Car()
        : this("No Make Info Provided", "No Model Info Provided", "0000")
    {

    }

    public Car(string Make, string Model, string Year)
    {
        //Console.WriteLine("I am a class constructor.");
        this._make = Make;
        this._model = Model;
        this._year = Year;
    }

    public void PrintCarDetails()
    {
        Console.WriteLine("Your car detail is as below:\nMake: {0}\nModel: {1}\nYear: {2}\n", this._make, this._model, this._year);
    }

    ~Car()
    {
        //Console.WriteLine("I am a destructor.");
    }

}

class Program
{
    public static void Main(string[] args)
    {
        Car carOne = new Car("Toyota", "Rav4", "2022");
        carOne.PrintCarDetails();

        // Calling default constructor
        Car carTwo = new Car();
        carTwo.PrintCarDetails();
    }
}