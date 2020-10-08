using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQCONCEPT
{
    class Linq
    {

        public static void SimpleLinq()//QUERY SYNTAX
        {
            List<int> List = new List<int> {1,2,3, 4, 5, 6, 7, 8, 9 };
            var querySyntax = from obj in List
                              where obj > 2
                              select obj;
             foreach ( var items in querySyntax)
            {
                Console.WriteLine(items);
            }
            Console.WriteLine("-------------------------");
     
            var methodsyntax = List.Where(obj => obj > 2);// method syntax and lambda expression
            foreach (var items in methodsyntax)
            {
                Console.WriteLine(items);
            }
            Console.WriteLine("-------------------------");// mixed syntax
            int[] scores = new int[] { 97, 92, 81, 60 };
            int minimum = scores.Min();//  finding minimum value 
            Console.WriteLine(minimum);
            int sum1 = scores.Sum();// finding sum of the values 
            Console.WriteLine(sum1);

            var mixedSyntax = (from obj1 in scores
                               select obj1).Max();// finding maximum values
            
            Console.WriteLine(mixedSyntax);
            Console.WriteLine("-------------------------");// operations orderby
            string[] words = { "apple", "pineapple","blueberry", "cheery"};
            var sortedWords = from items in words orderby items select items;
            foreach( var items in sortedWords)
            {
                Console.WriteLine(items);
            }
            
        }
        public static void enumerable()// enumerable 
        {
            int[] scores = new int[]{ 54, 59, 51, 50, 49, 45};
            IEnumerable<int> scoreQuery = from score in scores where score > 50 select score;
            foreach (var item in scores )
            {
                Console.WriteLine(item);
            }
        
        }


         public static void Main(string[] args)
        {
            SimpleLinq();
            enumerable();
        }
    }
}
