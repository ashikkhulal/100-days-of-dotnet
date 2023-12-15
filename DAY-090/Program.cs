using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Please enter a target number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Number number = new Number(userInput);
            //Thread T1 = new Thread(new ThreadStart(number.PrintNumbers));
            Thread T1 = new Thread(number.PrintNumbers);
            T1.Start();
        }
    }

    public class Number
    {
        private int _endNumber;

        public Number(int num) 
        {
            this._endNumber = num;
        }

        public void PrintNumbers()
        {
            int num = 0;
            Console.WriteLine("Printing from 1 to {0}:", _endNumber);
            for (int i = 1; i <= _endNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}