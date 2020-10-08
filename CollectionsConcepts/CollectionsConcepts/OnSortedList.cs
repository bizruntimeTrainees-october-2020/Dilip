using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsConcepts
{ 
    class SomeConceptsOnSortedList 
    {
         public static void  someSortedList()
         {
            Console.WriteLine("*****************SORTEDLISTS*************************");
            SortedList<int, string> ArrangedList = new SortedList<int, string>();
            ArrangedList.Add(5, "five");
            ArrangedList.Add(4, "four");
            ArrangedList.Add(3, "three");
             foreach(var kVP in ArrangedList)
            {
                Console.WriteLine("the elements on sortedlist are: " +kVP);
            }

        }
    }
}
