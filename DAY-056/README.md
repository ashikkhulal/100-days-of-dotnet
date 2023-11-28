# DAY-056:

## Generics in C#:

Generics are introduced in C# 2.0. Generics allow us to design classes and methods decoupled from the data types.

Generic classes are extensively used by collection classes available in System.Collections.Generic namespace.

One way of making AreEqual() method reusable, is to use object type parameters. Since, every type in .NET directly or indirectly inherits from System.Object type, AreEqual() method works with any data type, but the problem is perfomance degradation, due to boxing and unboxing happening.

Also, AreEqual() method is no longer type safe. It is now possible to pass integer for the first parameter, and a string for the second parameter. It doesn't really make sense to compare strings with integers.

So, the problem with using System.Object type is that
- AreEqual() method is not type safe.
- Performance degradation due to boxing and unboxing.

To make AreEqual() method generic, we specify a type parameter using angular brackets as shown below.

```public static bool AreEqual<T>(T firstValue, T secondValue)```

At the point, when the client code wants to invoke this method, they need to specify the type, they want the method to operate on. If the user wants the AreEqual() method to work with integers, they can invoke the method specifying int as the datatype using angular bracket as shown below:

```bool isEqual = Number.AreEqual<int>(1, 2);```

To operate with string data type:

```bool isEqual = Number.AreEqual<string>("ABC", "BCD");```

In this way we can make a method generic. Along the same lines, it is also possible to make classes, interfaces, and delegates generics.
