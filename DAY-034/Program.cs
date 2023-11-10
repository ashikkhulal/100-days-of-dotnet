using System;

public class Program
{
    public static void Main()
    {

    }
}

public class ClassA
{
    public virtual void Print()
    {
        Console.WriteLine("ClassA implementation");
    }
}

public class ClassB : ClassA
{
    public override void Print()
    {
        Console.WriteLine("ClassB implementation");
    }
}

public class ClassC : ClassA
{
    public override void Print()
    {
        Console.WriteLine("ClassC implementation");
    }
}

//public class ClassD : ClassB, ClassC
//{

//}