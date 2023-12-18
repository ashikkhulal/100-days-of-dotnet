using System;
using System.Diagnostics;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Processor count = {0}", Environment.ProcessorCount);

            Stopwatch stopwatch = Stopwatch.StartNew();
            SumOfEvenNumbers();
            SumOfOddNumbers();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Ticks without multiple threads = {0}", stopwatch.ElapsedTicks);


            stopwatch = Stopwatch.StartNew();
            Thread T1 = new Thread(SumOfEvenNumbers); 
            Thread T2 = new Thread(SumOfOddNumbers); 
            T1.Start();
            T2.Start();
            T1.Join();
            T2.Join();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Ticks with multiple threads = {0}", stopwatch.ElapsedTicks);
        }

        public static void SumOfEvenNumbers()
        {
            double sum = 0;
            for (int i = 0; i <= 1000000; i++) 
            {
                if ( i % 2 == 0 )
                {
                    sum += i;
                }
            }

            Console.WriteLine("Sum of even numbers until 1 million = {0}", sum);
        }

        public static void SumOfOddNumbers()
        {
            double sum = 0;
            for (int i = 0; i <= 1000000; i++)
            {
                if (i % 2 == 1)
                {
                    sum += i;
                }
            }

            Console.WriteLine("Sum of odd numbers until 1 million = {0}", sum);
        }
    }
}