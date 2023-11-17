using System;
using System.IO;
using System.Runtime.Serialization;

public class Program
{
    public static void Main()
    {
        string userName = "john123";

        try
        {
            throw new UserAlreadyLoggedInException();
            //throw new UserAlreadyLoggedInException($"User {userName} already has a logged in session. No duplicate session is allowed.");
        }
        catch (UserAlreadyLoggedInException ex) 
        {
            Console.WriteLine(ex.Message);
        }

    }    
}

[Serializable]
public class UserAlreadyLoggedInException : Exception
{
    public UserAlreadyLoggedInException() 
        : base ("User already has a logged in session. No duplicate session is allowed.") { }

    public UserAlreadyLoggedInException(string message) 
        : base (message) { }

    public UserAlreadyLoggedInException(string message, Exception innerException)
        : base(message, innerException) { }

    public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) 
        : base (info, context) { }
}
