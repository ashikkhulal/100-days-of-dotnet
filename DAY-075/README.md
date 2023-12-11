# DAY-075:

## Useful function in List collection class:

- `Contains()` function: checks if an item exists in the list. This method returns true if the item exists, else false.
- `Exist()` function: checks if an item exists in the list based on a condition. This method returns true if the item exists, else false.
- `Find()` function: searches for an element that matches the conditions defined by the specified lambda expression and returns the first matching item from the list.
- `FindLast()` function: searches for an element that matches the conditions defined by the specified lambda expression and returns the last matching item from the list.
- `FindAll()` function: returns all the items from the list that match the conditions specified by the lambda expression.
- `FindIndex()` function: returns the index of the first item, that matches the condition specified by the lambda expression. There are two other overloads of this method which allows us to specify the range of elements to search, within the list.
- `FindLastIndex()` function: returns the index of the last item, that matches the condition specified by the lambda expression. There are two other overloads of this method which allows us to specify the range of elements to search, within the list.

## Converting an array to a list: 

Use a `ToList()` method.

## Converting a list to an array: 

Use a `ToArray()` method.

## Converting a list to a dictionary: 

Use a `ToDictionary()` method.