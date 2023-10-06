## DAY-019:

### What is a class: 
A class consists of data and behavior. Class data is represented by its field and behavior is represented by its methods.

### Purpose of a class constructor:
The purpose of a class constructor is to initialize class fields. A class constructor is automatically called when an instance of a class is created.

Constructors do not have return values and always have the same name as the class.

Constructors are not mandatory. If we do not provide a constructor, a default paramaterless constructor is automatically provided.
Constructors can be overloaded by the number and type of parameters.

### Destructors:
Destructors have the same name as the class with `~` symbol in front of them.

They don't take any parameters and do not return a value.

Destructors are places where you could put code to release any resources your class was holding during its lifetime.
Normally, they are called when the C# garbage collector decides to clean your object from memory.