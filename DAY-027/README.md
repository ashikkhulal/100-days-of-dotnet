# DAY-027:

In C# to encapsulate and protect fields, we use properties. 

We use get (getter) and set (setter) accessors to implement properties.

## Read/write properties:

A property with both get and set accessor is a Read/ Write property.

## Read only properties:

A property with only get accessor is a Read only property.

## Write only properties:

A property with only set accessor is a Write only property.

## Auto implemented properties:

If there is no additional logic in the property accessors, then we can make use of auto-implemented properties introduced in C# 3.0.

Auto-implemented properties reduce the amount of code that we have to write.

When you use auto-implemented properties, the compiler creates a private, anonymous field that can be only be accessed through the property's get and set accessors.
