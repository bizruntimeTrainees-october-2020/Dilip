using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Concurrent
{
    class Concurrents
    {
        public static void Concurrenttype()
        {
            List<int> ints = new List<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            int count = ints.Count;
            Console.WriteLine(count);

            ConcurrentStack<int> stack = new ConcurrentStack<int>();

            stack.Push(41);
            stack.Push(04);
            stack.Push(010);
            stack.Push(101);
            stack.Push(200);
            stack.Push(004);

            if (stack.IsEmpty)
            {
                Console.WriteLine("The stack is empty!");
            }

            else
            {
                Console.WriteLine("The stack isn't empty");
            }
            ArrayList list1 = new ArrayList();
            list1.Add("One");
            list1.Add("Two");
            list1.Add("Three");
            list1.Add("Four");
            list1.Add("Five");
            Console.WriteLine("Elements in ArrayList...");
            foreach (string res in list1)
            {
                Console.WriteLine(res);
            }
            ArrayList list = ArrayList.Synchronized(list1);
            Console.WriteLine("Is ArrayList synchronized? = " + list.IsSynchronized);

            ConcurrentDictionary<string, string> dictionary = new ConcurrentDictionary<string, string>();
            dictionary.TryAdd("1", "First");
            dictionary.TryAdd("2", "Second");
            dictionary.TryAdd("3", "Third");
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key + "-" + item.Value);
            }
            string removedItem;
            bool result = dictionary.TryRemove("2", out removedItem); //Returns true
            Console.WriteLine(removedItem);

             
        }
         public static void Main(string[] args)
        {
            Concurrenttype();
        }

    }
}
