using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            //Thread T1 = new Thread(Number.PrintNumbers);
            //Thread T1 = new Thread(new ThreadStart(Number.PrintNumbers));
            //Thread T1 = new Thread(delegate() { Number.PrintNumbers(); }) ;
            Thread T1 = new Thread(()=> Number.PrintNumbers()) ;
            T1.Start();
        }
    }

    public class Number
    {
        public static void PrintNumbers()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}