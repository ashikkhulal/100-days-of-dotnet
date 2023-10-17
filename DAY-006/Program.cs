using System;

public class Program
{
    public static void Main()
    {
        string Name = null;
        int? i = null;
        float f = 0.0f;
        float? g = null;
        bool? isMale = null;



        int? AppleQuantity = null;
        int AvailableApple;

        if (AppleQuantity == null)
        {
            AvailableApple = 0;
        }
        else
        {
            //AvailableApple = AppleQuantity.Value;
            AvailableApple = (int)AppleQuantity;
        }

        Console.WriteLine("Available apples: {0}", AvailableApple);

        int? TicketsOnSale = null;
        int AvailableTickets = TicketsOnSale ?? 0;

        Console.WriteLine("Available tickets: {0}", AvailableTickets);
    }
}