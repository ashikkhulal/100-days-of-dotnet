# DAY-100:

## Func delegate in C#:

In simple terms, Func<T, TResult> is just a generic delegate. Depending on the requirement, the type parameters (T and TResult) can be replaced with the corresponding type arguments.

For example, `Fun<Customer, string>` is a delegate that represents a function expecting Customer object as an input parameter and returns a string.

## Difference between Func delegate and Lambda expression:

They're the same, just two different ways to write the same thing. The lambda syntax is newer, more concise and easy to write.

**What if I have to pass two or more input parameters?**

There are 17 overloaded versions of Func, which enables us to pass variable number and type of input parameters. In the example below, Func<int, int, string> represents a function that expects two int input parameters and returns a string.

```
public class Program 
{
    public static void Main()
    {
        Func<int, int, string> funcSum = (firstNum, secondNum) => "Sum is: " + (firstNum + secondNum).ToString();
        string result = funcSum(10, 20);
        Console.WriteLine(result);
    }
}
```
