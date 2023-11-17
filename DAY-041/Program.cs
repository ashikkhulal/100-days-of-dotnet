using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        try
        {
            try
            {
                Console.Write("Enter the first number: ");
                int firstNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int secondNumber = Convert.ToInt32(Console.ReadLine());

                int result = firstNumber / secondNumber;

                Console.WriteLine("{0} divided by {1} is: {2}", firstNumber, secondNumber, result);
            }
            catch (Exception ex)
            {
                string path = @"C:\Users\ashik\Desktop\Repos\ConsoleApp\ConsoleApp\log.txt";
                //string path = @"C:\Users\ashik\Desktop\Repos\ConsoleApp\ConsoleApp\log1.txt";
                if (File.Exists(path))
                {
                    StreamWriter streamWriter = new StreamWriter(path);
                    streamWriter.WriteLine("{0} - ERROR TYPE: {1}, ERROR: {2}", DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss"), ex.GetType().Name, ex.Message.ToLower());
                    streamWriter.Close();
                    Console.WriteLine("There is a problem, please try again later...");
                }
                else
                {
                    throw new FileNotFoundException(path + " is not found.", ex);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Current Exception: {0}", e.GetType().Name);
            if (e.InnerException != null)
            {
                Console.WriteLine("Inner Exception: {1}", e.InnerException.GetType().Name);
            }
        }


        
    }
    
}
