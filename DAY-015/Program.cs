using System;

public class Program
{
    public static void Main()
    {
        int[] numbers = { 0, 1, 2 };

        int i = 0;

        Console.WriteLine("Using while loop:");
        Console.Write("{ ");
        while (i < numbers.Length)
        {
            Console.Write(numbers[i] + " ");
            i++;
        }
        Console.Write("}");

        Console.WriteLine("\nUsing for loop:");
        Console.Write("{ ");
        for (int j = 0; j < numbers.Length; j++)
        {
            Console.Write(numbers[j] + " ");
        }
        Console.Write("}");

        Console.WriteLine("\nUsing foreach loop:");
        Console.Write("{ ");
        foreach(int k in numbers)
        {
            Console.Write(numbers[k] + " ");
        }
        Console.Write("}");

        Console.WriteLine("\nPrinting only until 10 using for loop and break:");
        for (int m = 0; m <= 15; m++)
        {
            Console.WriteLine(m);
            if (m >= 10)
            {
                break;
            }
        }

        Console.WriteLine("Printing even until 10 and regular using for loop and continue:");
        for (int n = 0; n <= 15; n++)
        {
            if (n% 2 == 0)
            {
                Console.Write(n + " ");
                continue;
            }

            if (n > 10)
            {
                Console.Write(n + " ");
                continue;
            }
            
        }
    }
}