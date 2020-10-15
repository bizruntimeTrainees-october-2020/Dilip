using Serilog;
using System;
using System.Data.SqlClient;


namespace DataTable11
{
    class ActiveDataObject
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.File(@"G:\trainer\logger.log").CreateLogger();
            Log.Information("hello");


            DataTble22 table = new DataTble22();
            table.dataTable();

            Adapter adp = new Adapter();
                Adapter.Adapter11();

            Log.CloseAndFlush();
            Console.WriteLine("completed");

        }
    }
}
