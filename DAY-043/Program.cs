using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        try
        {
            Console.Write("Please enter a numerator: ");
            int numerator = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter a denominator: ");
            int denominator = Convert.ToInt32(Console.ReadLine());

            int result = numerator / denominator;

            Console.WriteLine("Result is: {0}", result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please only enter a number");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Only numbers between {0} and {1} are allowed", Int32.MinValue, Int32.MaxValue);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("You cannot divide a number by zero. Denominator cannot be zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }    
}
