# DAY-020:

## Static and Instance class members:
When a class member includes a static modifier, the member is called as static member. 

When no static modifier is present the member is called as non static member or instance member.

Static members are invoked using class name, where as instance members are invoked using instances (objects) of the class.

An instance member belongs to specific instance (object) of a class. If I create 3 objects of a class, I will have 3 sets of instance members in the memory, where as there will ever be only one copy of a static member, no matter how many instances of a class are crreated.

```Note: class members = fields, methods, properties, events, indexers, constructors```

## Static constructors:

Static constructors are used to initialize static fields in a class.

You declare a static consturctor by using the keyword static in front of the constructor name.

Static constructor is called only once, no matter how many instances you create.

Static constructors are called before instance constructors.