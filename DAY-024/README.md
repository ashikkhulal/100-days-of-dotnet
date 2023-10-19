# DAY-024:

## Difference between method overriding and method hiding:

```
using System;

public class Program
{
    public static void Main()
    {
        BaseClassOverriding baseClassOverridingObject = new DerivedClassOverriding();
        baseClassOverridingObject.Print();
    }
}

public class BaseClassOverriding
{
    public virtual void Print()
    {
        Console.WriteLine("I am a base class's print method.");
    }
}

public class DerivedClassOverriding : BaseClassOverriding
{
    public override void Print()
    {
        Console.WriteLine("I am a child class's print method. - method overriding");
    }
}
```


In method overriding, a base class reference variable pointing to a child class object, will invoke the **overridden method in the child class**.

```
using System;

public class Program
{
    public static void Main()
    {
        BaseClassHiding baseClassHidingObject = new DerivedClassHiding();
        baseClassHidingObject.Print();
    }
}

public class BaseClassHiding
{
    public virtual void Print()
    {
        Console.WriteLine("I am a base class's print method. - method hiding");
    }
}

public class DerivedClassHiding : BaseClassHiding
{
    public new void Print()
    {
        Console.WriteLine("I am a child class's print method.");
    }
}
```

In method hiding a base class reference variable pointing to a child class object, will invoke the **hidden method in the base class**.

