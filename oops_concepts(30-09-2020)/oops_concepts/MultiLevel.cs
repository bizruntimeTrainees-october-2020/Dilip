using System;
using System.Collections.Generic;
using System.Text;

namespace oops_concepts
{
    public class MultiLevel
    {
        public void eat()
        {
            Console.WriteLine(" dog is eating ");
        }
    }
   public  class  Dog:MultiLevel
    {
        public void bark()
        {
            Console.WriteLine("dog is barking");
        }
    }
     public class Sleeping : Dog
    {
        public void Sleep()
        {
            Console.WriteLine("dog is sleeping");
        }
    }

}
