using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsConcepts
{
    class CollectionsConcept
    {
        static void Main(string[] args)
        {
            //array concept and methods 
            //non generic
            SomeConceptOnArray concept = new SomeConceptOnArray();//in the class if i give static in method 
            SomeConceptOnArray.SomeConcept();

            //hash concept and methods 
            //non generics example
            Hashconcept Hc = new Hashconcept();// if i dont give static in method
            Hc.SomeConceptOnHAsh();

            //list concept and methods
            // generic
            ListsConcept lc = new ListsConcept();
            ListsConcept.SomeConceptOnList();

            //sortedlist concept and methods
            //generics
            SomeConceptsOnSortedList SL = new SomeConceptsOnSortedList();
            SomeConceptsOnSortedList.someSortedList();

            //dictonary concept and methods
            //generics
            ConceptOnDictonary Dc = new ConceptOnDictonary();
            Dc.DictonaryConcept();// havent given static
            
            //stack concept and methods 
            //generics
            ConceptOnStack St = new ConceptOnStack();
            ConceptOnStack.stackConcept();

        }
           
    }
}
