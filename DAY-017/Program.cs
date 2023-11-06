using System;

public class Program
{
    public static void Main()
    {
        string[] names = { "John", "Mary", "Jack" };


        //ParamsMethod();      
        ParamsMethod(names);        
    }

    public static void ParamsMethod(params string[] names)
    {
        Console.WriteLine("Length of name array: {0}", names.Length);
        foreach (string s in names)
        {
            Console.WriteLine(s);
        }
    }
}