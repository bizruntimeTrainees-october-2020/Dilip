using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace CollectionsConcepts
{
    class Hashconcept
    {
        public void SomeConceptOnHAsh()
        {
            Console.WriteLine("*****************HASHTABLE*************************");
            Hashtable ht = new Hashtable();
            ht.Add("001", "zara");
            ht.Add("002", "armani");
            ht.Add("003'", "pumaIndia");
            ht.Add("004", "gully");

            if (ht.ContainsValue("addidas"))
            {
                Console.WriteLine("the product on particular brand exists");

            }
            else
            {
                ht.Add("005", "addidas");
            }
            ICollection keys = ht.Keys;//gets the collections of keys
            foreach(var k in keys)
            {
                Console.WriteLine("contents are :{0}" + k);
            }
            if(ht.ContainsKey("001"))
            {
                ht.Remove("gully");
            }
            else
            {
                Console.WriteLine("item doesnot exists");
            }
        }
    }
}
