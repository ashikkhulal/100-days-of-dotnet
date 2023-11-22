# DAY-050:

## Internal and protected internal access modifiers:

A member with internal access modifier is available anywhere within the containing assembly. It's a compile time error to access an internal member from outside the containing assembly.

Protected internal members can be accessed by any code in the assembly in which it is declared, or from within a derived class in another assembly. It is a combination of protected and internal.

|Access Modifier|Accessibility|
|-|-|
|Private|Only within the containing class|
|Public|Anywhere, no restrictions|
|Protected|Within the containing types and types derived from the containing type|
|Internal|Anywhere within the containing assembly|
|Protected Internal|Anywhere within the conatining assembly, and from within a derived class in any other assembly|

