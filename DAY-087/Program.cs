using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            //DoTimeConsumingWork();
            Thread doTimeConsumingWorkThread = new Thread(DoTimeConsumingWork);
            doTimeConsumingWorkThread.Start();
            PrintNumbers();
        }

        private static void DoTimeConsumingWork()
        {
            Console.WriteLine("Sleeping for 10s...");
            Thread.Sleep(10000);
        }

        private static void PrintNumbers()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}