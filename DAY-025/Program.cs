using System;

public class Program
{
    public static void Main()
    {
        Add(2, 1);
        Add(2, 1, 3);
        Add(2.0f, 1);
    }

    public static void Add(int num1, int num2)
    {
        Console.WriteLine("I was called - 1");
        Console.WriteLine("Sum is {0}", num1 + num2);
    }

    public static void Add(int num1, int num2, int num3)
    {
        Console.WriteLine("I was called - 2");
        Console.WriteLine("Sum is {0}", num1 + num2 + num3);
    }

    public static void Add(float num1, int num2)
    {
        Console.WriteLine("I was called - 3");
        Console.WriteLine("Sum is {0}", num1 + num2);
    }

    public static void Add(float num1, float num2, out float sum)
    {
        Console.WriteLine("I was called - 3");
        sum = num1 + num2;
        Console.WriteLine("Sum is {0}", sum);
    }
}