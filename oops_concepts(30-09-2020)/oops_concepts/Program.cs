
using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace oops_concepts
{
    class BasicsOOPS
    {
        public enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };//enum is used for storing  named constant values

        static void Main(string[] args)
        {
            Student S1 = new Student();
            S1.student1();

            Constructorclass c1 = new Constructorclass();//ceating instances for the class 
            c1.studentConstruct();//with the help of reference caalling the method
            c1.namealloatment(101, "tim", 2000.2f);
            c1.display();
         //ennum travesrsing 
            foreach (Days d in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine(d);
            }
         // instance creation on properties 
            Proper e1 = new Proper();
            e1.Name1 = "Dilip kumar";
            Console.WriteLine("Employee Name: " + e1.Name1);

            //inheritances
            Tester test = new Tester();
            Console.WriteLine("salary: " + test.salary);
            Console.WriteLine("bonus: " + test.bonus);

            //multiLevel inheritance
            Sleeping sleep = new Sleeping();
            sleep.eat();
            sleep.bark();
            sleep.Sleep();




        }
    }
}
