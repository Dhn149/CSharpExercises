using System;
using System.Collections.Generic;
using System.Linq;

namespace ExLinq
{
    class TuscanCities
    {
        public static void filtering(string TuscanCities)
        {
        
            var cities = new string[]{"Arezzo", "Arezzo", "Siena", "Firenze", "Lucca"};
           

            IEnumerable<string> queryTuscanCities=
            from city in cities
         
              where city == TuscanCities
            select city;

          foreach (var town in queryTuscanCities)
          {
              Console.WriteLine(town);
          }
          
           
        }


    }

}