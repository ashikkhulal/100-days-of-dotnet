using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Please enter a number either 10 or 20 or 30: ");
        int UserNumber = int.Parse(Console.ReadLine());

        switch(UserNumber)
        {
            case 10:
                Console.WriteLine("You entered 10.");
                break;
            case 20:
                Console.WriteLine("You entered 20.");
                break;
            case 30:
                Console.WriteLine("You entered 30.");
                break;
            default:
                Console.WriteLine("You entered {0}, which is neither 10 nor 20 nor 30.", UserNumber);
                break;
        }

        switch (UserNumber)
        {
            case 10:
            case 20:
            case 30:
                Console.WriteLine("You number is less than equal to 30.");
                break;
            default:
                Console.WriteLine("You entered {0}, which is greater than 30.", UserNumber);
                break;
        }
    }
}