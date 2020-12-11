using System;
using System.Collections.Generic;
using System.Linq;

namespace ExLinq
{
    class TuscanCities
    {
        public static IEnumerable<string> filtering(string TuscanCities)
        {
        
            var cities = new string[]{"Arezzo, Arezzo, Siena, Firenze, Lucca"};
           

            IEnumerable<string> queryTuscanCities=
            from city in cities
         
              where city == TuscanCities
            select city;

          foreach (string city in queryTuscanCities)
          {
              Console.Writeline($"{city}");
          }
           
        }


    }

}