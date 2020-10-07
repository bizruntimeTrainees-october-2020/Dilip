using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace oops_concepts
{ 
    class Developer
    {
        //string color = "black";
        public float salary = 4000;
    }
    class Tester: Developer//single level inheritance
    {
        //string color = "white" 
        public float bonus = 2000;
        public void Colors()
        {
            Console.WriteLine(base.salary);
        }
        
    }
}
