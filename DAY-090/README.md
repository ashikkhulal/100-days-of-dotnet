# DAY-090:

## Passing data to the Thread function in a type safe manner:

To pass data to the Thread function in a type safe manner, encapsulate the thread function and the data it needs in a helper class and use the ThreadStart delegate to execute the thread function.

```
public class Number
{
    private int _endNumber;

    public Number(int num) 
    {
        this._endNumber = num;
    }

    public void PrintNumbers()
    {
        int num = 0;
        Console.WriteLine("Printing from 1 to {0}:", _endNumber);
        for (int i = 1; i <= _endNumber; i++)
        {
            Console.WriteLine(i);
        }
    }
}
```

```
public static void Main()
{
    Console.Write("Please enter a target number: ");
    int userInput = Convert.ToInt32(Console.ReadLine());

    Number number = new Number(userInput);
    Thread T1 = new Thread(new ThreadStart(number.PrintNumbers));
    T1.Start();
}
```