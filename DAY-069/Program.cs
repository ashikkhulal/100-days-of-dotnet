using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            AddNumbers(2, 3);
            AddNumbers(4, 5, new int[] { 20, 28, 43});
            Print(50);
            Print(50, 75);
            Print(50, 75, 100);
            Print(50, c: 75);
            Print(50, b: 750);
        }

        public static void AddNumbers(int firstNum, int secondNum, int[] restofNums = null)
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

        public static void Print(int a, int b = 100, int c = 200) 
        {
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("c = {0}", c);
        }
    }
}