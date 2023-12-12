# DAY-079:

## Sorting a list of complex types using Comparison delegate:

One of the overloads of the Sort() method in the List class expects Comparison delegate to be passed as an argument.

`public void Sort(Comparision<T> comparison)`

**Approach 1:**

**Step-1**: Create a function whose signature matches the signature of System.Comparison delegate. This is the method where we need to write the logic to compare two customer objects.

```
private static int CompareCustomer(Customer x, Customer y)
{
    return x.Type.CompareTo(y.Type);
}
```

**Step-2**: Create an instance of System.Comparison delegate and then pass the name of the function created in step-1 as the argument. So, at this point the comparison delegate is pointing to our function that contains the logic to compare two customer objects.

`Comparison<Customer> comparingCustomer = new Comparison<Customer>(CompareCustomer);`

**Step-3**: Pass the delegate instance as an argument to Sort() method.

`listCustomers.Sort(comparingCustomer);`

**Approach 2:**

The approach 1 can be simplified using delegate keyword as shown below:

`listCustomers.Sort(delegate(Customer c1, Customer c2) { return c1.Type.CompareTo(c2.Type); });`

**Approach 3:**

It can be further simplified using lambda expression as below:

`listCustomers.Sort((x, y) => x.Type.CompareTo(y.Type));`