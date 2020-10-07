using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace oops_concepts
{
    class Constructorclass
    {
        public void studentConstruct()
        {
            Console.WriteLine(" default constructor class invoked");
        }
            int id;
            string name;
            float salary;
        public void namealloatment(int i,string n,float s)
        {
            id = i;
            name = n;
            salary = s;
        }
        public void display()
        {
            Console.WriteLine("the id of employee is " + id  + " his name is " + name + " salary is " + salary);
        }
    }
}
