using System;

public class Program
{
    public static void Main ()
    {
        int i = 0;
        bool isMale = true;

        Console.WriteLine("2 PLUS 2 is {0}", 2 + 2);
        Console.WriteLine("3 MINUS 3 is {0}", 3 - 3);
        Console.WriteLine("3 TIMES 3 is {0}", 3 * 3);
        Console.WriteLine("3 DIVIDE by 3 is {0}", 3 / 3);
        Console.WriteLine("When 3 is divided by 3, the REMAINDER is {0}", 3 % 3);

        Console.WriteLine("3 is EQUAL to 3: {0}", 3 == 3);
        Console.WriteLine("3 is NOT EQUAL to 3: {0}", 3 != 3);
        Console.WriteLine("3 is GREATER THAN 4: {0}", 3 > 4);
        Console.WriteLine("3 is LESS THAN 4: {0}", 3 < 4);
        Console.WriteLine("3 is LESS THAN OR EQUAL TO 4: {0}", 3 <= 4);
        Console.WriteLine("3 is GREATER THAN OR EQUAL TO 4: {0}", 3 >= 4);

        Console.WriteLine("3 is equal to 3 AND 4 is equal to 4: {0}", 3 == 3 && 4 == 4);
        Console.WriteLine("3 is equal to 3 AND 4 is equal to 5: {0}", 3 == 3 && 4 == 5);
        Console.WriteLine("3 is equal to 3 OR 4 is equal to 5: {0}", 3 == 3 || 4 == 5);
        Console.WriteLine("3 is equal to 3 OR 4 is equal to 4: {0}", 3 == 3 || 4 == 4);

        int num = 10;
        bool isNum10 = num == 10 ? true : false;

        Console.WriteLine("Number is 10 is {0}", isNum10);

        int age;

        Console.Write("Enter your age: ");
        age = Convert.ToInt32(Console.ReadLine());

        string canBuyAlcohol = age >= 21 ? "Yes" : "No";

        Console.WriteLine("Can you buy alcohol: {0}", canBuyAlcohol);
    }
}