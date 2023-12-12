# DAY-077:

## Sorting a list of simple types:

Sorting a list of simple types like int, string, char, etc. is straight forward. Just invoke the `Sort()` method on the list instance and the data will be automatically sorted in ascending order.

If you want the data to be retrieved in descending order, use `Reverse()` method on the list instance.

**How is the sort functionality working for simple types like int, string, char, etc...?**

That is because these types (int, string, decimal, char, etc) have already implemented IComparable interface.