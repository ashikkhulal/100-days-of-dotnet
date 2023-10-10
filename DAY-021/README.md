# DAY-021:

## Why inheritance:

- It allows code reuse
- Code reuse can reduce time and errors

You can specify all the common fields, properties, methods in the base class, which allows reusability. 

In the derived class, you will only have fields, properties and methods, that are specific to them.

## Inheritance Syntax:

```
public class ParentClass 
{
    // Parent class implementation
}

public class DerivedClass : ParentClass
{
    // Child class implementation
}
```

- In this example, DerivedClass inherits from ParentClass.
- C# supports only single class inheritance.
- C# supports multiple interface inheritance.
- Child class is a specilization of base class.
- Base classes are automatically instantiated before derived classes.
- Parent class constructor executes before child class constructor.
  