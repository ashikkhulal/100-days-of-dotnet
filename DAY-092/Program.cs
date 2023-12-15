using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Main started...\n");
            
            Thread T1 = new Thread(Thread1Function);
            T1.Start();
            //T1.Join();
            if (T1.Join(4000))
            {
                Console.WriteLine("Thread1Function completed in 4 seconds!");
            }
            else
            {
                Console.WriteLine("Thread1Function did not complete in 4 seconds!");
            }
            for (int i = 0; i < 10; i++)
            {
                if (T1.IsAlive)
                {
                    Console.WriteLine("Thread1Function is still running...");
                }
                else
                {
                    Console.WriteLine("Thread1Function completed from loop!\n");
                    break;
                }
            }
            

            Thread T2 = new Thread(Thread2Function);
            T2.Start();
            T2.Join();
            Console.WriteLine("Thread2Function completed!\n");

            Console.WriteLine("Main completed!");

        }

        public static void Thread1Function()
        {
            Console.WriteLine("Thread1Function started...");
            Thread.Sleep(4000);
            Console.WriteLine("Thread1Function is about to complete..");
            Thread.Sleep(1000);
            Console.WriteLine("Thread1Function finally completed!\n");
        }

        public static void Thread2Function()
        {
            Console.WriteLine("\nThread2Function started...");
        }

    }
}