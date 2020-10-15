using LoggersSeri;
using Serilog;
using System;
using System.Data.SqlClient;

namespace SeriLog
{
    class StructuredQueryLanguage
    {
        static void Main(string[] args)
        {
             Log.Logger = new LoggerConfiguration().WriteTo.File(@"G:\trainer\logfile.log").CreateLogger();
             Log.Information("hi");
            
            ActiveData data = new ActiveData();//calling a class 
            data.SubDivison();

            Log.CloseAndFlush();
           Console.WriteLine("completed");

        }
    }
}
