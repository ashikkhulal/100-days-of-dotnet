# DAY-094:

## Monitor vs Lock:

Both Monitor class and lock provides a mechanism that synchronizes access to objects.lock is the shortcut for Monitor.Enter with try and finally.

Hence AddOneMillon1() and AddOneMillon2() are essentially same method.

From C#4, Monitor class is implemented slightly differently:

```
public static void AddOneMillion3()
{
    for (int i = 0; i < 1000000; i++)
    {
        bool lockTaken = false;

        Monitor.Enter(_lock, ref lockTaken);
        try
        {
            Total++;
        }
        finally
        {
            if (lockTaken)
            {
                Monitor.Exit(_lock);
            }
        }
    }
}
```

So, in short, lock is a shortcut and its the option for the basic usage. If you need more control to implement advanced multithreading solutions using TryEnter(), Wait(), Pulse() and PulseAll() methods, then the Monitor class is your option.