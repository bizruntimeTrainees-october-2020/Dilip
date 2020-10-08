using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CollectionsConcepts
{
    class SomeConceptOnArray   
    {
        public static void SomeConcept()
        {
            Console.WriteLine("********************ARRAYLISTS**********************");
            ArrayList al = new ArrayList();
            Console.WriteLine("adding some numbers");
            al.Add(4);
            al.Add(5);
            al.Add(6);
            al.Add(7);
            Console.WriteLine("capacity: ", al.Capacity);//capacitiy of the arraylist
            Console.WriteLine("count: ", al.Count);//counts the values in the arraylist
            Console.WriteLine("fixedSize", al.IsFixedSize);//checking if array is fixed or extendable 
            Console.WriteLine("first element: ", al[0]);//accessing an element

            Console.Write("content: ");
            foreach( var i in al)//traversing each element on al
            {
                Console.WriteLine(i + " ");
            }

        }

    }
}
