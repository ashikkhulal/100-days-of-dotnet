# DAY-016:

## Methods in C#:

Methods are also called as functions. These terms are used interchangeably.

Methods are extremely useful because they allow you to define your logic once, and use it, at many places.

Methods make the maintenance of your application easier.

```
[attributes]
access-modifiers return-type method-name(parameters)
{
    Method body
}
```

- Attributes and access modifiers are first.
- Return type can be any valid data type or void.
- Method name can be any meaningful name, except reserved keywords.
- Parameters are optional.

## Difference between static and instance methods:

When a method declaration includes a static modifier, that method is said to be a static method. When no static modifier is present, the method is said to be an instance method.

Static method is invoked using the class name, whereas an instance method is invoked using an instance of the class.

The difference between instance methods and static methods is that multiple instances of a class can be created (or instantiated) and each instance has its own separate method. However, when a method is static, there is no instances of that method, and you can invoke only that one definition of the static method.