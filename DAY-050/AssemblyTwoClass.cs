using System;
using AssemblyOne;

namespace AssemblyTwo
{
    public class AssemblyTwoClassI : AssemblyOneClassI
    {
        public void SampleIIMethod()
        {
            AssemblyOneClassI A1 = new AssemblyOneClassI();
            //Console.WriteLine(A1.Id); // Not accessible since Id is internal access type
            Console.WriteLine(base.Name);
        }
    }
}