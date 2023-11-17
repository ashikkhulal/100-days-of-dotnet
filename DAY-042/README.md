# DAY-042:

## When to create custom exceptions:

When do you usually go for creating your own custom exceptions?

If none of the already existing dotnet exceptions adequately describes the problem.

Example:
- I have an ASP.NET application.
- The application should allow the user to have only one logged in session.
- If the user is already logged in, and if he opens another brower window and tries to log in again, the application should throw an error stating that he is already logged in.

With in the .NET framework, we don't have any exception that adequately describes above scenario. So this is where you may want to create a custom exception.

## Creating custom exceptions in C#:

- Create a class that derives from System.Exception class. As a convention, end the class name with Exception suffix. All .NET exceptions end with an exception suffix.
- Provide a public constructor that takes in a string parameter. This constructor simply passes the string parameter, to the base exception class constructor.
- Using InnerException, you can also track back the original exception. If you want to provide this capability for your custom exception class, then overload the constructor accordingly.
- If you want your Exception class object to work across application domains, then the object must be serializable. To make your exception class serializable mark it with Serializable attribute and provide a constructor that invokes the base Exception class constructor that takes in SerializationInfo and StreamingConext objects as parameters.

Note: It is also possible to provide your own custom serilization.

## Throwing and catching custom exception:

By using try / catch block as we usually do for system exceptions.