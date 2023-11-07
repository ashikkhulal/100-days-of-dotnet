# DAY-030:

## Interfaces in C#:

We create interfaces using interface keyword. Just like classes, interfaces also contains properties, methods, delegates or events, but only declarations and no implementations.

Its a compile time error to provide implementations for any interface member.

Interface members are public by default, and they don't allow explicit access modifiers.

Interfaces cannot contain fields.

If a class or a struct inherits from an interface, it must provide implementation for all interface members. Otherwise, we get a compiler error.

A class or a struct can inherit from more than one interface at the same time, but whereas, a class cannot inherit from more than once class at the same time.

Interfaces can inherit from other interfaces. A class that inherits this interface must provide implementation for all interface members in the entire interface inheritance chain.

We cannot create an instance of an interface, but an interface reference variable can point to a derived class object.

*Interface Naming Convention: Interface names are prefixed with capital I.*

