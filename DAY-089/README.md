# DAY-089:

## Parameterized ThreadStart Delegate:

```
Console.Write("Please enter a target number: ");
object userInput = Console.ReadLine();

Number number = new Number();
Thread T1 = new Thread(number.PrintNumbers);
T1.Start(userInput);
```

Here we are not explicitly creating an instance of ParameterizedThreadStart delegate. Then, how is it working?

It's working because the compiler implicitly converst

`Thread T1 = new Thread(number.PrintNumbers);`
TO
`Thread T1 = new Thread(new ParameterizedThreadStart(number.PrintNumbers));`

**When to use ParameterizedThreadStart over ThreadStart delegate?**

Use ParameterizedThreadStart delegate to pass data to the thread function.

---
An important note: Using ParameterizedThreadStart delegate and Thread.Start(Object) method to pass data to the Thread function is not type safe as they operate on object datatype and any type of data can be passed.

If you try to change the data type of the target parameter of PrintNumbers() method from object to int, a compiler error will be raised as the signature of PrintNumbers() method does not match with the signature of ParameterizedThreadStart delegate.
