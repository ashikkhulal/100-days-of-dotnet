using System;

public class Program
{
    public static void Main()
    {
        short[] values = (short[])Enum.GetValues(typeof(Gender));

        foreach (short value in values)
        {
            Console.WriteLine(value);
        }

        string[] names = (string[])Enum.GetNames(typeof(Gender));
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        Gender gender = (Gender)5;
        short num = (short)Gender.Unknown;
        Console.WriteLine(num);
    }  
    
}

public enum Gender : short
{
    Unknown = 1,
    Male = 5,
    Female
}

public enum Season
{
    Winter = 1,
    Spring = 2,
    Summer = 3,
    Autumn = 4
}
