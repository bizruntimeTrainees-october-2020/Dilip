using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace System
{
    class Multi
    {
        public void ExampleThreading ()
        {
            Thread thrd = Thread.CurrentThread;
            thrd.Name = "MainThread";
            Console.WriteLine(thrd.Name);
        }
    }
}
