# DAY-078:

## Sorting a list of complex types using IComparable:

When we try to use `Sort()` to sort the list on a complex type like Customer, we get a runtime invalid operation exception - Failed to compare two elements in the array. This is because .NET runtime does not know how to sort through the complex list types. We have to tell the way we want our data to be sorted in the list by implementing IComparable interface.

To sort a list of complex types without using LINQ, the complex type has to implement IComparable interface and provide implementation for CompareTo() method. CompareTo() method returns an integer, and the meaning of the return value is show below. RETURN VALUE is:

- Greater than ZERO - the current instance is greater than the object being compared with.
- Less than ZERO - the current instance is less than the object being compared with.
- is ZERO - the current instance is equal than the object being compared with.

```
public class Customer : IComparable<Customer>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public string Type { get; set; }

    public int CompareTo(Customer other)
    {
        if (this.Salary > other.Salary)
        {
            return 1;
        }
        else if (this.Salary < other.Salary)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}
```

Alternatively you can also invoke CompareTo() method since Salary property of the Customer class is int as CompareTo() method is already implemented on int type.

```
public class Customer : IComparable<Customer>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public string Type { get; set; }

    public int CompareTo(Customer other)
    {
        return this.Salary.CompareTo(other.Salary);
    }
}
```

## Sorting a list of complex types using IComparer:

If you prefer not to use the sort functionality provided by the class, then you can provide your own, by implementing IComparer interface. For example, if I want the customers to be sorted by salary:

**Step 1**: Implement IComparer interface:

```
public class SortBySalary : IComparer<Customer>
{
    public int Compare(Customer x, Customer y)
    {
        return x.Salary.CompareTo(y.Salary);
    }
}
```
**Step 2**: Pass an instance of the class that implements IComparer interface as an argument to the Sort() method.

```
SortBySalary sortBySalary = new SortBySalary();
listCustomers.Sort(sortBySalary);
```