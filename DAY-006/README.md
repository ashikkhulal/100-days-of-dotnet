# DAY-006

## Nullable types in C#

In C#, types are divided into two broad categories:

- Value types: int, float, double, structs, enums, etc.
- Reference types: interface, class, delegates, arrays, etc.

**By default value types are non nullable.** To make them nullable, **use ? after data type in declaration**

int i = 0; (i is non nullable int, so i can't be set to null, it will generate compiler error)
int? j = null; (j is nullable int, so j = null is legal)

Nullable types bridge the difference between C# types and database types.

## Null coalescing operator

`??`