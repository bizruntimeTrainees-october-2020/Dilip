using System;
using System.ComponentModel;
using System.Globalization;

namespace Delegatess
{
class TestingDelegates
    {
        public delegate void AddNumber(int value1, int value2);// declaring delegates with the 2 parameters 
        public delegate void MulNumber(int value1, int value2);// declaring delegates with the 2 parameters

        public  void AddNumbers(int value1, int value2)
        {
            Console.WriteLine( value1 + value2);
        }
          public void MulNumbers( int value1 ,  int value2 )
        {
            Console.WriteLine(value1 * value2);
        }

        static void Main(string[] args)
        {
            TestingDelegates obj = new TestingDelegates();// creating oject obj for class testingdelegates

            AddNumber Delegate_obj1 = new AddNumber(obj.AddNumbers);//creating instances for the delegate declared above
            MulNumber delegate_obj2 = new MulNumber(obj.MulNumbers);//creating instances for the delegate declared above

            Delegate_obj1(10, 20);//passing the parameter values
            delegate_obj2(20, 30);

        }
    }
}
