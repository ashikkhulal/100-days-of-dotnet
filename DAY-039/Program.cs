using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        IAmDelegate iAmDelegate1, iAmDelegate2, iAmDelegate3, iAmDelegate4;
        iAmDelegate1 = new IAmDelegate(IAmDelegateMethod1);
        iAmDelegate2 = new IAmDelegate(IAmDelegateMethod2);
        iAmDelegate3 = new IAmDelegate(IAmDelegateMethod3);
        iAmDelegate4 = iAmDelegate1 + iAmDelegate2 + iAmDelegate3;
        iAmDelegate4();
        iAmDelegate4 = iAmDelegate1 + iAmDelegate2 + iAmDelegate3 - iAmDelegate2;
        iAmDelegate4();

        IAmDelegate amDelegate = new IAmDelegate(IAmDelegateMethod1);
        amDelegate += IAmDelegateMethod2;
        amDelegate += IAmDelegateMethod3;
        amDelegate();
        amDelegate -= IAmDelegateMethod3;
        amDelegate();

        IAmDelegate2 amDelegate2 = new IAmDelegate2(IAmDelegateMethod4);
        amDelegate2 += IAmDelegateMethod5;
        int value = amDelegate2();

        Console.WriteLine("Delegate return value: {0}", value);

        IAmDelegate3 amDelegate3 = new IAmDelegate3(IAmDelegateMethod6);
        amDelegate3 += IAmDelegateMethod7;
        int value2 = -1;
        amDelegate3(out value2);

        Console.WriteLine("Delegate return value: {0}", value2);
    }

    public static void IAmDelegateMethod1()
    {
        Console.WriteLine("Implementation of IAmDelegateMethod1...");
    }

    public static void IAmDelegateMethod2()
    {
        Console.WriteLine("Implementation of IAmDelegateMethod2...");
    }

    public static void IAmDelegateMethod3()
    {
        Console.WriteLine("Implementation of IAmDelegateMethod3...");
    }

    public static int IAmDelegateMethod4()
    {
        return 4;
    }

    public static int IAmDelegateMethod5()
    {
        return 5;
    }

    public static void IAmDelegateMethod6(out int num)
    {
        num = 6;
    }

    public static void IAmDelegateMethod7(out int num)
    {
        num = 7;
    }
}

public delegate void IAmDelegate();
public delegate int IAmDelegate2();
public delegate void IAmDelegate3(out int integer);
