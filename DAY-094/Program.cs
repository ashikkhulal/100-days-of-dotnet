using System;
using System.Diagnostics;

namespace ConsoleApp
{
    public class Program
    {
        static int Total = 0;
        static object _lock = new object();
        public static void Main()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Thread T1 = new Thread(AddOneMillion1);
            Thread T2 = new Thread(AddOneMillion1);
            Thread T3 = new Thread(AddOneMillion1);
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

        public static void AddOneMillion1()
        {
            for (int i = 0; i < 1000000; i++)
            {
                lock (_lock)
                {
                    Total++;
                }
            }
        }

        // Method AddOneMillion1 and AddOneMillion2 are same
        public static void AddOneMillion2()
        {
            for (int i = 0; i < 1000000; i++)
            {
                Monitor.Enter(_lock);
                try
                {
                    Total++;
                }
                finally
                {
                    Monitor.Exit(_lock);
                }
            }
        }

        // Slight implementation difference from C# 4 than AddOneMillion2 of Monitor class
        public static void AddOneMillion3()
        {
            for (int i = 0; i < 1000000; i++)
            {
                bool lockTaken = false;

                Monitor.Enter(_lock, ref lockTaken);
                try
                {
                    Total++;
                }
                finally
                {
                    if (lockTaken)
                    {
                        Monitor.Exit(_lock);
                    }
                }
            }
        }
    }
}