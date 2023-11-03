using System;

public class Program
{
    public static void Main()
    {
        EvenNumbers();
        //OddNumbers();
    }

    public static void EvenNumbers()
    {
        Console.WriteLine("Welcome to even number printer!");
        Console.Write("Please enter your target: ");
        int userTarget = int.Parse(Console.ReadLine());

        int start = 0;

        while (start <= userTarget)
        {
            Console.Write(start + " ");
            start += 2;
        }
    }

    public static void OddNumbers()
    {
        Console.WriteLine("\nWelcome to odd number printer!");
        Console.Write("Please enter your target: ");
        int userTarget = int.Parse(Console.ReadLine());

        int start = 1;

        while (start <= userTarget)
        {
            if (start % 2 != 0)
            {
                Console.Write(start + " ");
            }
            start += 1;
        }
    }
}