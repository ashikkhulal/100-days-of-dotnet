using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            PartialMethodExample PM = new PartialMethodExample();
            PM.MethodTwo();
            PM.MethodThree();
            Console.WriteLine("Return = {0}", PM.MethodFour());
        }
    }
}