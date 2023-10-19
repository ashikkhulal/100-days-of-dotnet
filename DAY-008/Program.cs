using System;

public class Program
{
    public static void Main()
    {
        int[] evenNumbers = { 2, 4, 6, 8 };

        Console.WriteLine(evenNumbers[2]);

        int[] oddNumbers = new int[4];
        oddNumbers[0] = 1;
        oddNumbers[1] = 3;
        oddNumbers[2] = 5;
        oddNumbers[3] = 7;

        Console.WriteLine(oddNumbers[3]);

        int[] PrimeNumbers;
        PrimeNumbers = new int[6];
        PrimeNumbers[0] = 1;
        PrimeNumbers[1] = 2;
        PrimeNumbers[2] = 3;
        PrimeNumbers[3] = 5;
        PrimeNumbers[4] = 7;
        PrimeNumbers[5] = 11;

        Console.WriteLine(PrimeNumbers[5]);
    }

}