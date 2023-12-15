using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Please enter a target number: ");
            object userInput = Console.ReadLine();

            Number number = new Number();
            //ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(number.PrintNumbers);
            //Thread T1 = new Thread(parameterizedThreadStart);
            //T1.Start(userInput);
            
            Thread T1 = new Thread(number.PrintNumbers);
            T1.Start(userInput);
        }
    }

    public class Number
    {
        public void PrintNumbers(object endNum)
        {
            int num = 0;
            if(int.TryParse(endNum.ToString(), out num))
            {
                Console.WriteLine("Printing from 1 to {0}:", num);
                for (int i = 1; i <= num; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}