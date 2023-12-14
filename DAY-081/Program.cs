using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            //UsingList usingList = new UsingList();
            //usingList.GetCountryUsingList();

            UsingDictionary usingDictionary = new UsingDictionary();
            usingDictionary.GetCountryUsingDictionary();
        }
    }

    public class Country
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }
    }

}