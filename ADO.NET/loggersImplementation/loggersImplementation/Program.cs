using System;
using System.Runtime.CompilerServices;

[assembly : log4net.Config.XmlConfigurator(Watch =true)]

namespace loggersImplementation
{
    class LoggersImple
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static log4net.ILog GetLogger([CallerFilePath] string filename = "log.txt")
        {
            return log4net.LogManager.GetLogger(filename);
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");

            log.Error("this  is my error message ");
            Console.ReadLine();
        }
    }
}
