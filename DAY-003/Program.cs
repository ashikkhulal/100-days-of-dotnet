using System;

class Program
{
    static void Main()
    {
        bool isMale = true;

        int num = 0;

        Console.WriteLine("Min value for sbyte: {0}", sbyte.MinValue);
        Console.WriteLine("Max value for sbyte: {0}", sbyte.MaxValue);
        Console.WriteLine("Min value for byte: {0}", byte.MinValue);
        Console.WriteLine("Max value for byte: {0}", byte.MaxValue);
        Console.WriteLine("Min value for char: {0}", char.MinValue);
        Console.WriteLine("Max value for char: {0}", char.MaxValue);
        Console.WriteLine("Min value for short: {0}", short.MinValue);
        Console.WriteLine("Max value for short: {0}", short.MaxValue);
        Console.WriteLine("Min value for ushort: {0}", ushort.MinValue);
        Console.WriteLine("Max value for ushort: {0}", ushort.MaxValue);
        Console.WriteLine("Min value for int: {0}", int.MinValue);
        Console.WriteLine("Max value for int: {0}", int.MaxValue);
        Console.WriteLine("Min value for uint: {0}", uint.MinValue);
        Console.WriteLine("Max value for uint: {0}", uint.MaxValue);
        Console.WriteLine("Min value for long: {0}", long.MinValue);
        Console.WriteLine("Max value for long: {0}", long.MaxValue);
        Console.WriteLine("Min value for ulong: {0}", ulong.MinValue);
        Console.WriteLine("Max value for ulong: {0}", ulong.MaxValue);

        float money = 10.25F;
        double PI = 3.141516;

        Console.WriteLine("Min value for float: {0}", float.MinValue);
        Console.WriteLine("Max value for float: {0}", float.MaxValue);
        Console.WriteLine("Min value for double: {0}", double.MinValue);
        Console.WriteLine("Max value for double: {0}", double.MaxValue);

        decimal PI2 = 3.1415167119272M;       
    }
}