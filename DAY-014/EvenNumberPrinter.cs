using System;

public class Program
{
    public static void Main()
    {
        string userInput = "";
        Console.WriteLine("Welcome to an even number printer!");

        do
        {
            Console.Write("Please enter your target: ");
            int userTarget = int.Parse(Console.ReadLine());

            int start = 0;

            while (start <= userTarget)
            {
                Console.Write(start + " ");
                start += 2;
            }

            do
            {
                Console.Write("\nDo you want to continue? Enter Y for yes or N for no: ");
                userInput = Console.ReadLine();
                if (userInput.ToUpper() != "Y" && userInput.ToUpper() != "N")
                {
                    Console.Write("Invalid choice, please enter Y for yes or N for no: ");
                }
            } while (userInput.ToUpper() != "Y" && userInput.ToUpper() != "N");
        } while (userInput.ToUpper() == "Y");

        Console.WriteLine("Thank you for using even number printer. Have a good day!");
    }
}