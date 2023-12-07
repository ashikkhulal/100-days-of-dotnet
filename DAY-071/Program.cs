using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                for (int num = 0; num < 10; num++)
                {
                    Console.WriteLine(num);
                }
            }
            catch (Exception)
            {
                throw;
            }


        }
    }
}