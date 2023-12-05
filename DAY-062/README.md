# DAY-062:

## Rules to follow when creating partial classes:

- All the parts spread across different files, must use the partial keywords.
- All the parts spread across different files, must also have the same access modifiers.
- If any of the parts are declared abstract, then the entire type is considered abstract.
- If any of the parts are declared sealed, then the entire type is considered sealed.
- If any of the parts inherits a class, then the entire parts inherits the class.
- C# does not support multiple class inheritance. Different parts of the partial class, must NOT specify different base classes.
- Different parts of the partial class can specify different base interfaces, and the final type implements all the interfaces listed by all of the partial declarations.
- Any members that are declared in a partial definition are available to all of the other parts of the partial class.
