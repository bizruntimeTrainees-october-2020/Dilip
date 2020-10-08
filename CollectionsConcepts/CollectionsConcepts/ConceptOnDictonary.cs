using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsConcepts
{
    class ConceptOnDictonary
    {
        public  void DictonaryConcept()
        {
            Console.WriteLine("****************DICTONARY**************************");
            IDictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "One"); //adding a key and value using the Add method
            dict.Add(2, "Two");
            dict.Add(3, "Three");
            foreach (KeyValuePair<int, string> kvp in dict)
            {
                Console.WriteLine("the values in the dictonary are: " + kvp.Key, kvp.Value);//accessing values
            }
                var cities = new Dictionary<string, string>()
                {
                   {"UK", "London, Manchester"},
                   { "USA", "Chicago,Washington"},
                   {"India", "Mumbai, New Delhi"}
                };
                  Console.WriteLine(cities["UK"]);
            string result;
            if (cities.TryGetValue("singapore", out result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("no citiy found");

            }

            cities["USA"] ="new york";//updating yhe value
            Console.WriteLine(cities["USA"]);



        }
    }
}
