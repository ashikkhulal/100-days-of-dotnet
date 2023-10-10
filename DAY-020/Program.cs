using System;

class Program
{
    static void Main()
    {
        // Calling instance member
        Rectange rectange1 = new Rectange(10.5, 5.5);
        double Area1 = rectange1.CalculateArea();
        Console.WriteLine("Area of the rectange is {0} sq unit.", Area1);

        Rectange rectange2 = new Rectange(16.5, 9.5);
        double Area2 = rectange2.CalculateArea();
        Console.WriteLine("Area of the rectange is {0} sq unit.", Area2);

        Circle circle = new Circle(10.4);
        double Circumference = circle.CalculateCircumference();
        Console.WriteLine("Circumference of the circle is {0} unit.", Circumference);

        // Calling static member of Circle class
        Console.WriteLine(Circle._PI);

    }
}

class Rectange
{
    // Instance members
    double _length;
    double _width;

    public Rectange(double Length, double Width)
    {
        this._length = Length;
        this._width = Width;
    }

    public double CalculateArea()
    {
        return this._length * this._width;
    }
}

class Circle
{
    // Public static member
    public static double _PI;
    // Instance member
    double _radius;

    static Circle()
    {
        Console.WriteLine("I am a static constructor.");
        Circle._PI = Math.PI;
    }

    public Circle(double Radius)
    {
        this._radius = Radius;
    }

    public double CalculateCircumference()
    {
        return 2* Circle._PI * this._radius;
    }
}
