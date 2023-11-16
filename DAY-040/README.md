# DAY-040:

## Exception handling in C#:
An exception is an unforeseen error that occurs when a program is running.

Examples:
Trying to read from a file that does not exist, throws FileNotFoundException.
Trying to read from a database table that does note exist, throws a SqlException.

Showing actual unhandled exceptions to the end user is bad for two reasons:
- Users will be annoyed as they are cryptic and does not make much sense to the end users.
- Exceptions contain information, that can be used for hacking into your application.

An exception is actually a class that derives from System.Exception class. The System.Exception class has several useful properties, that provide valuable information about the exception.

**Message:** Gets a message that describes the current exception.

**StackTrace:** Provides the call stack to the line number in the method where the exception occured.

## Releasing system resources:

We use try, catch and finally blocks for exception handling:

**try** - the code that can possibly cause an exception will be in the try block.

**catch** - handles the exception.

**finally** - clean and free resources that the class was holding onto during the program execution. Finally block is optional.

**Note**: It is a good practice to always release resources in the finally block, because finally block is guaranteed to execute, irrespective of whether there is an exception or not.

Specific exceptions will be caught before the base general exception, so specific exception blocks should always be on top of the base exception block. Otherwise, you will encounter a compiler error.