using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            bool isEqual = Number<int>.AreEqual(1, 1);
            //bool isEqual = Number.AreEqual<string>("AB", "BC");
            //bool isEqual = Number.AreEqual<char>('a', 'a');
            if (isEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
            
        }
    }

    public class Number<T>
    //public class Number
    {
        public static bool AreEqual(T firstValue,  T secondValue)
        //public static bool AreEqual<T>(T firstValue,  T secondValue)
        {
            return firstValue.Equals(secondValue);
        }
    }

}