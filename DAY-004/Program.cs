using System;

public class Program
{
    public static void Main()
    {
        string FirstName = "Ashik";
        Console.WriteLine("FirstName: {0}", FirstName);
        string LastName = "\"Khulal\"";
        Console.WriteLine("LastName (in double quote): {0}", LastName);
        string OneTwoThree = "One\nTwo\nThree";
        Console.WriteLine("One two three: {0}", OneTwoThree);
        string Path = "C:\\Users\\ashik\\Desktop\\Repos\\Kudvenkat Csharp Course\\DAY-004";
        Console.WriteLine("File Path: {0}", Path);
        string VerbatimLiteralPath = @"C:\Users\ashik\Desktop\Repos\Kudvenkat Csharp Course\DAY-004";
        Console.WriteLine("File Path (with verbatim literal): {0}", VerbatimLiteralPath);
    }
}