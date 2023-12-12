using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            List<int> numbers = new List<int>() { 2, 5, 1, 4, 8, 7, 3, 6, 9 };

            Console.WriteLine("Before sorting:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("\nAfter sorting:");
            numbers.Sort();
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("\nReversing the order:");
            numbers.Reverse();
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

            List<char> alphabets = new List<char>() { 'B', 'E', 'A', 'D', 'C', 'G', 'H', 'F'};

            Console.WriteLine("\nBefore sorting:");
            foreach (char alphabet in alphabets)
            {
                Console.Write(alphabet + " ");
            }

            Console.WriteLine("\nAfter sorting:");
            alphabets.Sort();
            foreach (char alphabet in alphabets)
            {
                Console.Write(alphabet + " ");
            }

            Console.WriteLine("\nIn reverse order:");
            alphabets.Reverse();
            foreach (char alphabet in alphabets)
            {
                Console.Write(alphabet + " ");
            }
        }
    }
}