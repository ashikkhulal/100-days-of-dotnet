using System;
using System.Runtime.InteropServices;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            AddNumbers(2, 3);
            AddNumbers(4, 5, new int[] { 20, 28, 43});
        }

        //public static void AddNumbers(int firstNum, int secondNum, [OptionalAttribute] int[] restofNums)
        public static void AddNumbers(int firstNum, int secondNum, [Optional] int[] restofNums)
        {
            int result = firstNum + secondNum;
            
            if (restofNums != null)
            {
                foreach (int num in restofNums)
                {
                    result += num;
                }
            }

            Console.WriteLine("Sum is: {0}", result);
        }
    }
}