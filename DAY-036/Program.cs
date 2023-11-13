using System;

public class Program
{
    public static void Main()
    {
        HelloMethodDelegate helloMethodDelegate = new HelloMethodDelegate(Hello);
        helloMethodDelegate("Hello from delegate");
    }

    public static void Hello(string strMessage)
    {
        Console.WriteLine(strMessage);
    }
}

public delegate void HelloMethodDelegate(string strMessage);