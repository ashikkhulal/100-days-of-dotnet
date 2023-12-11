# DAY-074:

## List collection class in C#:

List is one of the generic collection classes present in System.Collections.Generic namespace. There are several generic collection classes in Generic namespace:
- Dictionary
- List
- Stack
- Queue, etc

A list class can be used to create a collection of any type.

For example: we can create a list of integers, strings and even complex types.

The objects stored in the list can be accessed by index.

Unlike arrays, list can grow in size automatically.

This class also provides methods to search, sort, and manipulate lists.

## Adding to the list:

Use `Add()` function.

```
List<Customer> listCustomer = new List<Customer>(2);
listCustomer.Add(customer1);
```

## Inserting to the list:

Use `Insert()` function.

```
List<Customer> listCustomer = new List<Customer>(2);
listCustomer.Insert(0, customer2);
```