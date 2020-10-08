using All;
using System;
using System.Linq;
using System.Threading;

namespace  thread
{
    class ThreadMain
    {
        public void thread1()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(3000);
            }
        }
    }
     class OneMore
    { 
        static void Main(string[] args)
        {
            Multi thr = new Multi();
            thr.ExampleThreading();

            Examplethread thread1 = new Examplethread();
            Examplethread thread2 = new Examplethread();
            thread1.secondClass();

            Console.WriteLine("start of main");
            ThreadMain mt = new ThreadMain();
            Thread t11 = new Thread(new ThreadStart(mt.thread1));
            Thread t22 = new Thread(new ThreadStart(mt.thread1));
            t11.Start();
            t22.Start();
           
         
        }
    }
}
