using System;

public class Program
{
    public static void Main()
    {
        int totalCost = 0;

        BuyCoffee:
        Console.Write("Please select your coffee size:\n    1 - Small\n    2 - Medium\n    3 - Large\nYour choice: ");
        int userChoice = int.Parse(Console.ReadLine());

        switch (userChoice)
        {
            case 1:
                totalCost += 1;
                Console.WriteLine("You selected small size coffee.");
                break;
            case 2:
                totalCost += 2;
                Console.WriteLine("You selected medium size coffee.");
                break;
            case 3:
                totalCost += 3;
                Console.WriteLine("You selected large size coffee.");
                break;
            default:
                Console.WriteLine("You entered an invalid choice!");
                goto BuyCoffee;
        }

        BuyAnotherCoffee:
        Console.Write("Do you want to buy another cup of coffee? Enter either Y for yes or N for no: ");
        string buyAgain = Console.ReadLine();

        switch (buyAgain.ToUpper())
        {
            case "Y":
                goto BuyCoffee;
            case "N":
                break;
            default:
                Console.WriteLine("You entered an invalid choice! Please try again...");
                goto BuyAnotherCoffee;
        }


        Console.WriteLine("Your total cost is ${0}.", totalCost);
        Console.WriteLine("Thank you for shopping with us.");
    }
}