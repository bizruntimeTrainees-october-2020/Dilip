using System;
using System.Collections;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
namespace Collections
{
    class Collections
    {
        public static void Generics()//generics
        {
            List<int> mylist = new List<int>();//creating an collection intializer for list
            for(int numbers= 5;numbers<10;numbers++)
            {
                mylist.Add(numbers * 3);
            }
            foreach (int items in mylist)//for each is used to traverese the data
                Console.WriteLine(items);
        }
        public static void NonGenerics()//non generics 
        {
            Queue myQueue = new Queue();
            myQueue.Enqueue("FirstName");
            myQueue.Enqueue("MiddleName");
            myQueue.Enqueue("lastName");

            Console.WriteLine("total number of name format available is ");
            Console.WriteLine(myQueue.Count);
            Console.WriteLine("begining item of myqueue is " + myQueue.Peek());
                
        }
        static void Main(string[] args)
        {
            Generics();
            NonGenerics();
            
        }
    }
}
