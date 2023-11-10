# DAY-034:

## Problems of multiple class inheritance:

```
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
```

- ClassB and ClassC inherits from ClassA.
- ClassD inherits from both ClassB and ClassC.
- If a method in ClassD class a method defined in ClassA (and does not override the method), and ClassB and ClassC have overridden that method differently, then from which class does it inherit: ClassB or ClassC?

**This ambiguity is called ad Diamond problem.**

