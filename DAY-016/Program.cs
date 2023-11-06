using System;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        program.EvenNumbers();

        Program.OddNumbers(50);

        Console.WriteLine(program.Add(2, 2));
    }

    public void EvenNumbers()
    {
        int start = 0;

        Console.WriteLine("Even numbers until 50:");
        while (start <= 100)
        {
            Console.WriteLine(start);
            start += 2;
        }
    }

    public static void OddNumbers(int end)
    {
        int start = 1;

        Console.WriteLine("\nOdd numbers until {0}:", end);
        while (start <= end)
        {
            if (start % 2 != 0)
            {
                Console.WriteLine(start);
            }
            start += 2;
        }
    }

    public string Add(int firstNumber, int secondNumber)
    {
        return $"Sum of {firstNumber} and {secondNumber} is: {firstNumber + secondNumber}";
    }
}