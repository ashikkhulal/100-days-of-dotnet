using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            AddNumbers(2, 3);
            AddNumbers(4, 5, 6);
            AddNumbers(4, 5, 6, 7);
            AddNumbers(4, 5, 6, 7, new int[] { 20, 28, 30});
        }

        public static void AddNumbers(int firstNum,  int secondNum)
        {
            int result = firstNum + secondNum;
            
            Console.WriteLine("Sum is: {0}", result);
        }

        public static void AddNumbers(int firstNum, int secondNum, int thirdNum)
        {
            int result = firstNum + secondNum + thirdNum;

            Console.WriteLine("Sum is: {0}", result);
        }

        public static void AddNumbers(int firstNum, int secondNum, int thirdNum, int fourthNum)
        {
            int result = firstNum + secondNum + thirdNum + fourthNum;

            Console.WriteLine("Sum is: {0}", result);
        }

        public static void AddNumbers(int firstNum, int secondNum, int thirdNum, int fourthNum, int[] restofNums)
        {
            int result = firstNum + secondNum + thirdNum + fourthNum;
            
            foreach (int num in restofNums)
            {
                result += num;
            }

            Console.WriteLine("Sum is: {0}", result);
        }
    }
}