using System;

namespace AssemblyOne
{
    public class AssemblyOneClassI
    {
        internal int Id = 101;
        protected internal string Name = "John";
    }

    public class AssemblyOneClassII
    {
        public void SampleIMethod()
        {
            AssemblyOneClassI A1 = new AssemblyOneClassI();
            Console.WriteLine(A1.Id);
        }
    }
}