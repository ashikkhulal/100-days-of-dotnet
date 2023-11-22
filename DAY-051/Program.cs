using System;
using AssemblyOne;

public class Program
{
    public static void Main()
    {
        AssemblyOneClassI A1 = new AssemblyOneClassI();
        A1.AssemblyOneClassMethod();

        //AssemblyOneClassII is not accessible here as it has an internal access type
        //AssemblyOneClassII A2 = new AssemblyOneClassII();
        //A2.Id = 102;

    }
}

