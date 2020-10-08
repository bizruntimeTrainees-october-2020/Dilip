using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Collection
{
    class Collections
    {
        public static void creating_a_List()// GENERICS
        {
            var primenumbers = new List<int>();// creating an list 
            primenumbers.Add(4);// adding values into the list by add method
            primenumbers.Add(5);
            primenumbers.Add(6);
            primenumbers.Add(7);
            Console.WriteLine("No of elelemts: " + primenumbers.Count);
            Console.WriteLine("elements present at 3 is " + primenumbers[2]);//accesing the values present in list
            primenumbers.RemoveAt(1);// if we try accessing index not present in list it gives ArgumentOutOfRangeException
            foreach (var i in primenumbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(primenumbers.Contains(7));// the values present in list or not
        }
        public static void SortedList()
        {
            SortedList<int, String> NumberNames =  new SortedList<int, string>();//sortedList declaration
            NumberNames.Add(4, "four");
            NumberNames.Add(1, "one");
            NumberNames.Add(10, "ten");
            NumberNames.Add(9, "nine");
           
            foreach( var kvp in NumberNames)
            {
                Console.WriteLine("Key:{0}, Value:{1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine(NumberNames[1]);// accesing values in sortedList
            /*Console.WriteLine(NumberNames[5]);*/
            Console.WriteLine(NumberNames.Remove(1));//removing key 1 
        }
        public static void Dictonaries()
        {
            var cities = new Dictionary<string, string>() { {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}};
            Console.WriteLine(cities["UK"]);
            Console.WriteLine(cities["India"]);
        }

        public static void Arraylists()//NON GENERICS
        {
            var arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add("name");
            arlist1.Add("null");
            arlist1.Add(2.1);

            arlist1.Remove("null");//removing null element

            var arlist2 = new ArrayList()
            {2,"donald", 4.4 , 'c'};

            Console.WriteLine("-------ArrayList of 1st elements are-----------");
            for (int i = 0; i < arlist1.Count; i++)
            {
                Console.WriteLine(arlist1[i]);
            }
            Console.WriteLine("-----------array list 2nd elements are----------");
            for (int i = 0; i < arlist2.Count; i++)
            {
                Console.WriteLine(arlist2[i]);
            }
        }
        public static void stackex()
        {
            Stack<int> numbers = new Stack<int>();
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);
            numbers.Push(4);
            numbers.Push(7);

            foreach (var item in numbers)
                Console.WriteLine(item + ",");
            Console.WriteLine("Number of elements in Stack: {0}", numbers.Count);
            if (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Peek());// returns value 7
            }
            while (numbers.Count > 0)
                Console.WriteLine(numbers.Pop() + ",");
            Console.WriteLine("Number of elements in Stack: {0}", numbers.Count);
        }
        static void Main(string[] args)
        {
            creating_a_List();//List method 
            SortedList();// sortedList
            Dictonaries();//dictonary
            Arraylists();//non generic array list
            stackex();
        }
    }
}
