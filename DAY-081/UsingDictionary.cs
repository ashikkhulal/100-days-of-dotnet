using System;

namespace ConsoleApp
{
    public class UsingDictionary
    {
        Country country1 = new Country()
        {
            Code = "AUS",
            Name = "AUSTRALIA",
            Capital = "CANBERRA",
        };

        Country country2 = new Country()
        {
            Code = "IND",
            Name = "INDIA",
            Capital = "NEW DELHI",
        };

        Country country3 = new Country()
        {
            Code = "NPL",
            Name = "NEPAL",
            Capital = "KATHMANDU",
        };

        Country country4 = new Country()
        {
            Code = "USA",
            Name = "UNITED STATES",
            Capital = "WASHINGTON D.C.",
        };

        Country country5 = new Country()
        {
            Code = "GER",
            Name = "GERMANY",
            Capital = "BERLIN",
        };

        Country country6 = new Country()
        {
            Code = "GBR",
            Name = "UNITED KINGDOM",
            Capital = "LONDON",
        };

        Country country7 = new Country()
        {
            Code = "CAN",
            Name = "CANADA",
            Capital = "OTTAWA",
        };

        Dictionary<string, Country> dictionaryCountries = new Dictionary<string, Country>();

        public void GetCountryUsingDictionary()
        {
            dictionaryCountries.Add(country1.Code, country1);
            dictionaryCountries.Add(country2.Code, country2);
            dictionaryCountries.Add(country3.Code, country3);
            dictionaryCountries.Add(country4.Code, country4);
            dictionaryCountries.Add(country5.Code, country5);
            dictionaryCountries.Add(country6.Code, country6);
            dictionaryCountries.Add(country7.Code, country7);

            string continueProgram;

            do
            {
                Console.Write("Please enter the country code: ");
                string countryCode = Console.ReadLine().ToUpper();

                if (dictionaryCountries.ContainsKey(countryCode))
                {
                    Country countryResult = dictionaryCountries[countryCode];
                    Console.WriteLine("Name = {0}, Capital = {1}", countryResult.Name, countryResult.Capital);
                }
                else
                {
                    Console.WriteLine("The entered country code ({0}) is invalid!", countryCode);
                }

                do
                {
                    Console.Write("Do you want to try again - YES or NO? ");
                    continueProgram = Console.ReadLine().ToUpper();

                    if (continueProgram != "YES" && continueProgram != "NO")
                    {
                        Console.WriteLine("Invalid choice entered. Enter either YES or NO!");
                    }
                } while (continueProgram != "YES" && continueProgram != "NO");

            } while (continueProgram == "YES");

        }
    }
}
