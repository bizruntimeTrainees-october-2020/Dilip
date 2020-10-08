using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CollectionsConcepts
{
    class ListsConcept
    {
        public static void SomeConceptOnList()
        {
            Console.WriteLine("******************LISTS************************");
            List<int> numbers = new List<int>();
            numbers.Add(7);
            numbers.Add(8);
            numbers.Add(9);
            numbers.Add(10);

            string[] cities = new String[3]{ "Bengaluru", "London", "New York" };
            var popularCities = new List<string>();
            popularCities.AddRange(cities);
            Console.WriteLine( "the cities are: "+ cities.Count());
            Console.WriteLine(numbers.Contains(7));
        }
    }
}
