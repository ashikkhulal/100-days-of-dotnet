using System;

namespace ConsoleApp
{
    public partial class PartialMethodExample
    {
        partial void MethodOne();

        public void MethodTwo()
        {
            MethodOne();
            Console.WriteLine("Implementation of method two...");
        }

        public partial void MethodThree();

        public partial void MethodThree()
        {
            Console.WriteLine("Implementation of method three...");
        }

        public partial int MethodFour();

        public partial int MethodFour()
        {
            return 2 + 2;
        }
    }

}
