# DAY-047:

## Enum concepts:

If a program uses set of integral numbers, consider replacing them with enums, which makes the program more:
- Readable
- Maintainable

1. Enums are enumerations.
2. Enums are strongly typed constants. Hence, an explicit cast is needed to convert from enum type to an integral type and vice versa. Also, an enum of one type cannot be implicitly assigned to an enum of another type even though the underlying value of their members are the same.
3. The default members are the same.
4. The default value for the first element is ZERO and gets increemented by 1.
5. It is possible to customize the underlying type and values.
6. Enums are value types.
7. `enum` keyword (all small letters) is used to create enumerations, where as `Enum` class contains static GetValues() and GetNames() methods which can be used to list Enum underlying type values and names.