using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        try
        {
            Console.Write("Please enter a numerator: ");
            int numerator;
            bool isNumeratorInteger = Int32.TryParse(Console.ReadLine(), out numerator);

            if (isNumeratorInteger)
            {

                Console.Write("Please enter a denominator: ");
                int denominator;
                bool isDenominatorInteger = Int32.TryParse(Console.ReadLine(), out denominator);

                if (isDenominatorInteger && denominator != 0)
                {
                    int result = numerator / denominator;
                    Console.WriteLine("Result is: {0}", result);
                }
                else
                {
                    if (denominator == 0 && isDenominatorInteger)
                    {
                        Console.WriteLine("You cannot divide a number by zero. Denominator cannot be zero.");
                    }
                    else
                    {
                        Console.WriteLine("Denominator should be a valid number between {0} and {1}.", Int32.MinValue, Int32.MaxValue);
                    }
                }
            }
            else
            {
                Console.WriteLine("Numerator should be a valid number between {0} and {1}.", Int32.MinValue, Int32.MaxValue);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }    
}
