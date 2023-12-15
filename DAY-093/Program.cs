using System;
using System.Diagnostics;

namespace ConsoleApp
{
    public class Program
    {
        static int Total = 0;
        //static object _lock = new object();
        public static void Main()
        {
            //AddOneMillion();
            //AddOneMillion();
            //AddOneMillion();
            //Console.WriteLine("Total is: {0}", Total);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Thread T1 = new Thread(AddOneMillion);
            Thread T2 = new Thread(AddOneMillion);
            Thread T3 = new Thread(AddOneMillion);
            T1.Start();
            T2.Start();
            T3.Start();
            
            T1.Join();
            T2.Join();
            T3.Join();
            Console.WriteLine("Total is: {0}", Total);
            stopwatch.Stop();
            Console.WriteLine("Total time (in ticks) took: {0}", stopwatch.ElapsedTicks);

        }

        // Results in inconsistent result everytime we run this program for above total in line 25
        //public static void AddOneMillion() 
        //{
        //    for (int i = 0; i < 1000000; i++)
        //    {
        //        Total++;
        //    }
        //}

        // Solution 1 for consistent result for above total in line 25
        public static void AddOneMillion()
        {
            for (int i = 0; i < 1000000; i++)
            {
                Interlocked.Increment(ref Total);
            }
        }

        // Solution 2 for consistent result for above total in line 25 (also uncomment line 8)
        //public static void AddOneMillion()
        //{
        //    for (int i = 0; i < 1000000; i++)
        //    {
        //        lock (_lock)
        //        {
        //            Total++;
        //        }
        //    }
        //}
    }
}