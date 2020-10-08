using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace TaskSynch
{
    class TaskinkConstruction
    {
         public static void TaskCreation()
        {
            Thread t1 =Thread.CurrentThread;
            Console.WriteLine("thread ID:{0}", t1.ManagedThreadId);//properties of current thread
            Console.WriteLine("Is backgroundThread:{0}", t1.IsBackground);// is any thread runnning background
            Console.WriteLine("current thread is alive :{0}", t1.IsAlive);
            Console.WriteLine("current thread state:{0}", t1.ThreadState);
        }
        public static void printMsg()// method
        {
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("i value is {0}", i);
            }
            Console.WriteLine("child thread is completed ");

        }
        public static void printInfo()
        {
            Console.WriteLine("Method excecution");
        }
        public static void Main(string[] args)
         {
            TaskCreation();//calling 
            Thread t2 = new Thread(new ThreadStart(printMsg));
            t2.Start();// initiating the thread t2
            Console.WriteLine("main thread completed ");

            Thread t3 = new Thread(new ThreadStart(printInfo));
            Console.WriteLine("thread state :{0}", t3.ThreadState);
            t3.Start();
            Console.WriteLine("thread state:{0}", t3.ThreadState);
            t3.Join();
            Console.WriteLine("thread state1 :{0}", t3.ThreadState);

            Task t = Task.Factory.StartNew(() => 
            {
                int counter = 0;
                for (counter = 0; counter <= 100; counter++)
                { }
                Console.WriteLine("Finished {0} loop iterations",
                                  counter);
            });
            t.Wait();
            var task = Task.Factory.StartNew(new Action(printInfo));//synatx to run any method 

        }
    }
}
