# DAY-053:

## The basics of reflection:
Reflection is the ability of inspecting an assemblies' metadata at runtime. It is used to find all types in an assembly and/or dynamically invoke methods in an assembly.

## Understanding the uses of reflections:
- When you drag and drop a button on a win forms or an ASP.NET application, the properties window uses reflection to show all the properties of the button class. So, reflection is extensively used by IDE or a UI designers.
- Late binding can be achieved by using reflection. You can use reflection to dynamically create an instance of a type, about which we don't have any information at compile time. So, reflection enables you to use code that is not available at compile time.
- Consider an example where we have two alternative implementations of an interface. You want to allow the user to pick one or the other using a config file. With reflection, you can simply read the name of the class whose implementation you want to use from the config file, and instantiate an instance of that class. This is another example of late binding using reflection.