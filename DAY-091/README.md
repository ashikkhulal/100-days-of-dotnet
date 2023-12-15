# DAY-091:

## Retrieving data from Thread function using callback method:

Main thread retrieves the target number from the user.

Main thread creates a child thread and passes the target number to the child thread.

The child thread computes the sum of numbers and then returns the target number and the sum of numbers to the main thread using the callback function.

The callback method then prints the sum statement.

**Step 1**: Create a callback delegate. The actual callback method signature should match the signature of this delegate.

`public delegate void SumOfNumbersCallBack(int targetNumber, int sumOfNumbers);`

**Step 2**: Create a helper class to compute the sum of numbers and to call the callback method.

```
public class Number
{
    private int _endNumber;
    SumOfNumbersCallBack _callBackMethod;

    public Number(int num, SumOfNumbersCallBack callBackMethod) 
    {
        this._endNumber = num;
        this._callBackMethod = callBackMethod;
    }

    public void SumOfNumbers()
    {
        int sum = 0;
        for (int i = 1; i <= _endNumber; i++)
        {
            sum += i;
        }

        if(_callBackMethod != null)
        {
            _callBackMethod(_endNumber, sum);
        }
    }
}
```

**Step 3**: This class consumes the Number class created in step 2.

```
public static void Main()
{
    Console.Write("Please enter a target number: ");
    int userInput = Convert.ToInt32(Console.ReadLine());

    SumOfNumbersCallBack callBackDelegate = new SumOfNumbersCallBack(PrintSumOfNumbers);

    Number number = new Number(userInput, callBackDelegate);
    Thread T1 = new Thread(number.SumOfNumbers);
    T1.Start();
}

public static void PrintSumOfNumbers(int targetNumber, int result)
{
    Console.WriteLine("Sum of all numbers upto {0} is: {1}", targetNumber, result);
}
```
