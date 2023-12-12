# DAY-076:

## Generic list class and ranges:

- `AddRange()`: `Add()` method allows you to add one items at a time to the end of the list, where as `AddRange()` allows you to add another list of items, to the end of the list.

- `GetRange()`: Using an item index, we can retrieve only one item at a time from the list, if you want to get a list of items from the list, then use `GetRange()` function. This function expects 2 parameters, i.e. the start index in the list and the number of elements to return.

- `InsertRange()`: `Insert()` allows you to insert a single item into the list at a specified index, whereas `InsertRange()` allows you, to insert another list of items to your list at the specified index.

- `RemoveRange()`: `Remove()` function removes only the first matching item from the list. `RemoveAt()` function, removes the item at the specified index in the list. `RemoveAll()` function removes all the items that matches the specified condition. `RemoveRange()` method removes a range of elements from the list. This function expects 2 parameters, i.e. the start index in the list and the number of elements to remove. If you want to remove all the elements from the list without specifying any condition, then use `Clear()` function.
