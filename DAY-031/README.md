# DAY-031:

## Explicit interface implementation:

**Question: A class inherits from 2 interfaces and both the interfaces have the same method name. How should the class implement the method for both the interfaces?**

We use explicit implementation technique to solve this problem.

Note: When a class explicitly implements an interface member, the interface can no longer be accessed thru class reference variable, but only thru the interface reference variable.

Access modifiers are not allowed on explicity implemented interface members.

## Default implementation:

If you want to make one of the interface method a default method, then implement that method normally and the other interface methods explicitly. This makes the default method to be accessible thru class instance.