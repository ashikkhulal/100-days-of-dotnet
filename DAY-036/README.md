# DAY-036:

## Basics of delegates:

A delegate is a type safe function pointer. That is, it holds a reference (pointer) to a function.

The signature of the delegate must match the signature of the function, the delegate points to, otherwise you get a compiler error. This is the reason delegates are called as type safe function pointers.

A delegate is similar to a class. You can create an instance of it, and when you do so, you pass in the function name as a parameter to the delegate constructor, and it is to this function the delegate will point to.

*Tip to remember delegate syntax: Delegates syntax look very much similar to a method with a delegate keyword.*


