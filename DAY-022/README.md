# DAY-022:

## Method hiding:

Use the new keyword to hide a base class member. *(You will get a compiler warning if you miss the new keyword.)*


## Invoke hidden base class members:
There are different ways to invoke a hidden base class members from derived class:

1. Use base keyword
2. Cast child type to parent type and invoke the hidden member
3. Instantiating object as the parent class type.
    ```
    ParentClass PC = new ChildClass();
    PC.HiddenMethod();
    ```