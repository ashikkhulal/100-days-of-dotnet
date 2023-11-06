# DAY-017:

## Methods parameters:

There are 4 different types of parameters a method can have:

## Value parameters:

Creates a copy of the parameter passed, so modifications does not affect each other.

```
public static void Main()
{
    int i = 0;
    SimpleMethod(i);
    Console.WriteLine(i);
}

public static void SimpleMethod(int j)
{
    j = 101;
}
```

## Reference parameters:

The ref method parameter keyword on a method parameter causes a method to refer to the same variable that was passed into the method. Any changes made to the parameter in the method will be reflected in that variable when control passes back to the calling method.

```
public static void Main()
{
    int i = 0;
    SimpleMethod(ref i);
    Console.WriteLine(i);
}

public static void SimpleMethod(ref int j)
{
    j = 101;
}
```

## Out parameters:

Use when you want a method to return more than one value.

```
public static void Main()
{
    int sum = 0;
    int product = 0;

    Calculate(10, 20, out sum, out product);
    Console.WriteLine("Sum = {0}, and product = {1}", sum, product);
}

public static void Calculate(int firstNum, int secondNum, out int sum, out int product)
{
    sum = firstNum + secondNum;
    product = firstNum * secondNum;
}
```

## Parameter arrays:

The params keyword lets you specify a method parameter that takes a variable number of arguments. You can send a comma-separated list of arguments, or an array, or no arguments. Params keyword should be the last one in a method declaration, and only one params keyword is permitted in a method declaration.
