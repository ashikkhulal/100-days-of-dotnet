using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp
{
    public delegate void SumOfNumbersCallBack(int targetNumber, int sumOfNumbers);
    
    public class Program
    {
        public static void Main()
        {
            Console.Write("Please enter a target number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            SumOfNumbersCallBack callBackDelegate = new SumOfNumbersCallBack(PrintSumOfNumbers);

            Number number = new Number(userInput, callBackDelegate);
            Thread T1 = new Thread(number.SumOfNumbers);
            T1.Start();
        }

        public static void PrintSumOfNumbers(int targetNumber, int result)
        {
            Console.WriteLine("Sum of all numbers upto {0} is: {1}", targetNumber, result);
        }
    }

    public class Number
    {
        private int _endNumber;
        SumOfNumbersCallBack _callBackMethod;

        public Number(int num, SumOfNumbersCallBack callBackMethod) 
        {
            this._endNumber = num;
            this._callBackMethod = callBackMethod;
        }

        public void SumOfNumbers()
        {
            int sum = 0;
            for (int i = 1; i <= _endNumber; i++)
            {
                sum += i;
            }

            if(_callBackMethod != null)
            {
                _callBackMethod(_endNumber, sum);
            }
        }
    }
}