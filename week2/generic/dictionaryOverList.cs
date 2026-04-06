// Find method of the List Class loops through each object in the list until a match is found. so if we want to lookup a value using a key dictionary is better for performance over list.
// so use dictionary when we know the collection will be primarily ued for lookups.

// using System;

// namespace DictionaryOverList
// {
//     public class DictionaryOverList
//     {
//         public static void Main()
//         {
//             Country country1 = new Country() { Code="AUS",  Name="AUSTRALIA", Capital="Canberra" };
//             Country country2 = new Country() { Code="IND",  Name="INDIA", Capital="New Delhi" };
//             Country country3 = new Country() { Code="USA",  Name="UNITED STATES", Capital="Washington D.C." };
//             Country country4 = new Country() { Code="GBR",  Name="UNITED KINGDOM", Capital="London" };
//             Country country5 = new Country() { Code="CAN",  Name="CANADA", Capital="Ottawa" };


//             List<Country> listCountries = new List<Country>();
//             listCountries.Add(country1);
//             listCountries.Add(country2);
//             listCountries.Add(country3);
//             listCountries.Add(country4);
//             listCountries.Add(country5);
            
//             string strUserChoice = string.Empty;
//             do
//             {
//                 Console.WriteLine("Please enter country code");
//                 string strCountryCode = Console.ReadLine().ToUpper();

//                 Country resultCountry = listCountries.Find(country => country.Code == strCountryCode);

//                 if(resultCountry == null)
//                 {
//                     Console.WriteLine("Country code not valid");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Name = {0}, Capital={1}", resultCountry.Name, resultCountry.Capital);
//                 }

//                 do
//                 {
//                     Console.WriteLine("Do you want to continue - YES or NO?");
//                     strUserChoice = Console.ReadLine().ToUpper();
//                 } while(strUserChoice != "NO" && strUserChoice != "YES");

//             } while(strUserChoice == "YES");
//         }
//     }

//     public class Country
//     {
//         public String Name { get; set; }
//         public String Code { get; set; }
//         public String Capital { get; set; }
//     }
// }


// the above code is not efficient as we are finding a object so in that case dictionary is the suitable collection to use.

using System;

namespace DictionaryOverList
{
    public class DictionaryOverList
    {
        public static void Main()
        {
            Country country1 = new Country() { Code="AUS",  Name="AUSTRALIA", Capital="Canberra" };
            Country country2 = new Country() { Code="IND",  Name="INDIA", Capital="New Delhi" };
            Country country3 = new Country() { Code="USA",  Name="UNITED STATES", Capital="Washington D.C." };
            Country country4 = new Country() { Code="GBR",  Name="UNITED KINGDOM", Capital="London" };
            Country country5 = new Country() { Code="CAN",  Name="CANADA", Capital="Ottawa" };


            Dictionary<string, Country> dictCountries = new Dictionary<string, Country>();
            dictCountries.Add(country1.Code, country1);
            dictCountries.Add(country2.Code, country2);
            dictCountries.Add(country3.Code, country3);
            dictCountries.Add(country4.Code, country4);
            dictCountries.Add(country5.Code, country5);
            
            string strUserChoice = string.Empty;
            do
            {
                Console.WriteLine("Please enter country code");
                string strCountryCode = Console.ReadLine().ToUpper();

                Country resultCountry = dictCountries.ContainsKey(strCountryCode) ? dictCountries[strCountryCode] : null;

                if(resultCountry == null)
                {
                    Console.WriteLine("Country code not valid");
                }
                else
                {
                    Console.WriteLine("Name = {0}, Capital={1}", resultCountry.Name, resultCountry.Capital);
                }

                do
                {
                    Console.WriteLine("Do you want to continue - YES or NO?");
                    strUserChoice = Console.ReadLine().ToUpper();
                } while(strUserChoice != "NO" && strUserChoice != "YES");

            } while(strUserChoice == "YES");
        }
    }

    public class Country
    {
        public String Name { get; set; }
        public String Code { get; set; }
        public String Capital { get; set; }
    }
}