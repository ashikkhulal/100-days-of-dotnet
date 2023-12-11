# DAY-073:

## Useful functions in Dictionary collection class:

- `TryGetValue()`
- `Count()`
- `Remove()`
- `Clear()`
  
## Using LINQ extension methods with dictionary:

```
Console.WriteLine("Total items in customerDictonary whose Salary is greater than 90K = {0}", customerDictonary.Count(kvp => kvp.Value.Salary > 90000));
```

## Converting List and Arrays to dictionary:

Use a `ToDictionary()` method.