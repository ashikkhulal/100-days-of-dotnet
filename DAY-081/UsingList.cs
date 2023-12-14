using System;

namespace ConsoleApp
{
    public class UsingList
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

        List<Country> listCountries = new List<Country>();

        public void GetCountryUsingList()
        {
            listCountries.Add(country1);
            listCountries.Add(country2);
            listCountries.Add(country3);
            listCountries.Add(country4);
            listCountries.Add(country5);
            listCountries.Add(country6);
            listCountries.Add(country7);

            string continueProgram;

            do
            {
                Console.Write("Please enter the country code: ");
                string countryCode = Console.ReadLine().ToUpper();

                Country countryResult = listCountries.Find(x => x.Code == countryCode);

                if (countryResult != null)
                {
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