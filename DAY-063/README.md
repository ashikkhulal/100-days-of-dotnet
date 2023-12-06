# DAY-063:

## What are partial methods in C#:

A partial class or a partial struct can contain partial methods. A partial method is created using partial keyword,

## Rules to follow when creating partial methods:

- A partial method declaration consists of two parts:
  - The definition (only the method signature)
  - The implementation
(*These may be in separate parts of a partial class, or in the same part.*)

- The implementation for a partial method is optional. If we don't provide the implementation, the compiler removes the signature and all calls to the method.
- Partial methods are private by default.
- It is a compile time error to include declaration and implementation at the same time for a partial method.
- Signature of the partial method must match the signature of its implementation.
- A partial method must be declared within a partial class or a partial struct. A non partial class or a non partial struct cannot include partial methods.
- A partial method can be implemented only once. Trying to implement a partial method more than once raises a compile time error.
