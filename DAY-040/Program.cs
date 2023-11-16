using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        string path = @"C:\Users\ashik\Desktop\Repos\ConsoleApp\ConsoleApp\Data1.txt";
        StreamReader streamReader = null;
        try
        {
            streamReader = new StreamReader(path);
            Console.WriteLine(streamReader.ReadToEnd());
            
        }
        catch (FileNotFoundException) 
        {
            Console.WriteLine("ERROR: file \"{0}\" not found at the path \"{1}\". Please check if the file exists in the given directory.", Path.GetFileName(path), Path.GetDirectoryName(path));
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("ERROR: path \"{0}\" not found. Please check if the given directory path is correct.", Path.GetDirectoryName(path));
        }
        catch (Exception ex)
        {
            Console.WriteLine("ERROR: {0}", ex.Message);
            //Console.WriteLine("TRACE: {0}", ex.StackTrace);
        }
        finally 
        {
            if (streamReader != null)
            {
                streamReader.Close();
            }
        }
    }
    
}
