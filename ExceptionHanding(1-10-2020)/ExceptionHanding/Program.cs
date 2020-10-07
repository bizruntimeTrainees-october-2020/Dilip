using System;
using System.IO;
using System.Security.Cryptography;

namespace ExceptionHanding
{
    class Exceptionhandling
    {
        public static void  HandlingAnError()
        {
            Console.Write("Please enter a number to divide 100: ");
            

            try
            {
                int num = int.Parse(Console.ReadLine());//returns string values

                int result = 100 / num;

                Console.WriteLine(result);
            }
            catch (DivideByZeroException )
            {
                Console.WriteLine("Cannot divide by zero. Please try again.");
            }
            catch (FormatException )
            {
                Console.WriteLine("Not a valid format. Please try again.");
            }
            
        }
        public  static void HandlingOtherError()
        {
            try
            {
                StreamReader reader = new StreamReader("new.txt");//reading a file
                {
                    reader.ReadToEnd();// reading till the last character
                }
                
            }
            catch(Exception)
            {
                Console.WriteLine(" error occured");
            }
             finally
            {

                Console.WriteLine(" try searching the file present in database");
            }
        }
         public static void checkingForAge(int Age)
        { 
            if(Age < 18)
            {
                throw new ArgumentException("you are not elligible for voting");
            }
            else
            {
                Console.WriteLine("you are elligible for voting");
            }
        }


        public static void Main(string[] args)
        {
            HandlingAnError();
            HandlingOtherError();
            checkingForAge(14);
        }
    }
}
