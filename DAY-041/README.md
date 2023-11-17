# DAY-041:

## Inner exception handling in C#:

The InnerException property returns the exception instance that caused the current exception.

To retain the original exception, pass it as a parameter to the constructor, of the current exception.

Always check if inner exception is not null before accessing any property of the inner exception object, else, you may get Null Reference Exception.

To get the type of InnerException, use GetType() method.