using System;
using System.Linq.Expressions;

namespace PredicateDelegates
{
    class Delegates
    {
        public delegate void my_delegate(int value1, int value2);// action delegate declaration

        public static int mymethod(int number1, int number2, int number3)//function delegate
        {
            return number1 * number2 * number3;
        }

        public static void Fun(int value1 , int value2)// action delegates
        {
            Console.WriteLine(value1 - value2);
        }
        public static bool myfun(string mystring)// predicate delegate
        {
            if (mystring.Length < 7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Predicate<string> val = myfun;// creating an instances for the predicate delegate
            Console.WriteLine(val("helloworld"));//passing string value

            my_delegate obj = Fun;//creating an instance for action delegate 
            obj(10, 5);//passing parameter value to it

            Func<int, int, int, int> value = mymethod;// creating an instance for function delegate
            Console.WriteLine(value(10, 20, 30));

            Test test = new Test();
            test.TestEvent();
            Console.ReadKey();
        }
    }
    //events
    public class MyTest
    {
        public event EventHandler MyEvent//declaring event 
        {
            add
            {
                Console.WriteLine("add operation");
            }
            remove
            {
                Console.WriteLine("remove operation");
            }
        }
    }
    public class Test
    {
        public void TestEvent()
        {
            MyTest myTest = new MyTest();
            myTest.MyEvent += myTest_MyEvent;
            myTest.MyEvent -= myTest_MyEvent;
        }
        public void myTest_MyEvent(object sender, EventArgs e)
        {
        }
    }
  
}
