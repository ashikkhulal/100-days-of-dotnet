using System;

public class Program
{
    public static void Main()
    {
        BaseClassOverriding baseClassOverridingObject = new DerivedClassOverriding();
        baseClassOverridingObject.Print();

        BaseClassHiding baseClassHidingObject = new DerivedClassHiding();
        baseClassHidingObject.Print();
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