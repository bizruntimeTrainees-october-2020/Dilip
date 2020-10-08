using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsConcepts
{
    class ConceptOnStack
    {
        public static void stackConcept()
        {
            Console.WriteLine("****************STACK**************************");
            Stack<int> mystack = new Stack<int>();
            mystack.Push(9);
            mystack.Push(8);
            mystack.Push(7);
            mystack.Push(6);
             foreach(var item in mystack)
            {
                Console.WriteLine(item + "," );
            }
            Console.WriteLine("number of elements on stack is {0}", +mystack.Count);
            if(mystack.Count>0)
            {
                Console.WriteLine(mystack.Peek());
            }
        }
    }
}
