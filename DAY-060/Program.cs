using System;
using System.Text;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            string userString = "C#";
            userString += " video";
            userString += " tutorial";
            userString += " for";
            userString += " beginners";

            Console.WriteLine(userString);

            StringBuilder userString2 = new StringBuilder("C#");
            userString2.Append(" video");
            userString2.Append(" tutorial");
            userString2.Append(" for");
            userString2.Append(" beginners");

            Console.WriteLine(userString2.ToString());

            // String object will create from 0-9999 unneccessary objects in heap memory
            string str1 = string.Empty;
            for (int i = 0; i < 10000; i++)
            {
                str1 = i.ToString() + " ";
            }
            Console.WriteLine(str1);

            // This will give better performance as StringBuilder is mutable
            StringBuilder str2 = new StringBuilder();
            for (int j = 0;j < 10000; j++)
            {
                str2.Append(j.ToString() + " ");
            }
            Console.WriteLine(str2.ToString());
        }
    }
}