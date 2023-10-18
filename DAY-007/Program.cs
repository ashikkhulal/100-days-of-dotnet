using System;

public class Program
{
    public static void Main()
    {
        int i = 100;
        int f = i;
        Console.WriteLine("Implicitly converting int type i to float type f: {0}", f);

        float x = 123.45f;
        int y = (int)x;
        //int y = Convert.ToInt32(x);
        Console.WriteLine("Explicitly converting float type x to int type y: {0}", y);

        string strNum = "20";
        int toInt = int.Parse(strNum);
        Console.WriteLine("Parsing string type strNum to int type toInt : {0}", toInt);

        string strNum2 = "20G";
        int toInt2 = 0;
        bool canConvert = int.TryParse(strNum2, out toInt2);

        if (canConvert )
        {
            Console.WriteLine("Able to parse string type strNum to int type toInt! Value of toInt is: {0}", toInt2);
        }
        else
        {
            Console.WriteLine("Not able to parse string type strNum to int type toInt! Value of toInt is: {0}", toInt2);
        }
    }
}