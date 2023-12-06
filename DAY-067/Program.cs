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
            AddNumbers(4, 5, 6, 7, 10, 20, 30);
            AddNumbers(4, 5, new object[] { 6, 7, 10, 20, 30, 18 });
            
        }

        public static void AddNumbers(int firstNum,  int secondNum, params object[] restofNums)
        {
            int result = firstNum + secondNum;
            if (restofNums != null)
            {
                foreach (int num in  restofNums)
                {
                    result += num;
                }
            }

            Console.WriteLine("Sum is: {0}", result);
        }
    }
}