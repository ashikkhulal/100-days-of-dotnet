using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Calculator.Add(10, 20);
        Console.WriteLine("Sum is: {0}", Calculator.Add(new List<int>() { 10, 20, 30, 40 }));
    }
}

public class Calculator
{
    [Obsolete("Use Add(List<int> numbers) method instead")]
    //[Obsolete("Instead use Add(List<int> numbers) method", true)]
    //[ObsoleteAttribute("Instead use Add(List<int> numbers) method")]
    public static int Add(int firstNum, int secondNum)
    {
        return firstNum + secondNum;
    }

    public static int Add(List<int> numbers)
    {
        int Total = 0;
        foreach (int num in numbers)
        {
            Total += num;
        }

        return Total;
    }
}

