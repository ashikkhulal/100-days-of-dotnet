using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Please enter either 1 or 2 or 3 and I will guess: ");

        int userNumber = int.Parse(Console.ReadLine());

        if (userNumber == 1)
        {
            Console.WriteLine("You entered 1");
        }

        if (userNumber == 2)
        {
            Console.WriteLine("You entered 2");
        }

        if (userNumber == 3)
        {
            Console.WriteLine("You entered 3");
        }

        if (userNumber != 1 && userNumber != 2 && userNumber != 3)
        {
            Console.WriteLine("Your number is not either 1 or 2 or 3");
        }

        if (userNumber == 10 || userNumber == 20 )
        {
            Console.WriteLine("Your number is either 10 or 20");
        }
    }

    public void ImprovedCondition()
    {
        int userNumber = int.Parse(Console.ReadLine());

        if (userNumber == 1)
        {
            Console.WriteLine("You entered 1");
        }
        else if (userNumber == 2)
        {
            Console.WriteLine("You entered 2");
        }
        else if (userNumber == 3)
        {
            Console.WriteLine("You entered 3");
        }
        else
        {
            Console.WriteLine("Your number is not either 1 or 2 or 3");
        }
    }
}