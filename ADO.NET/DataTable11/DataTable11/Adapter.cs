using Serilog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataTable11
{
    class Adapter
    {
        public  static void  Adapter11()
        {
            SqlConnection connection = null;
            try
            {
                string clientConection = "data source =.; database = StudentDB; integrated security = SSPI";//assigning value to clientConnection
                connection = new SqlConnection(clientConection);
                SqlDataAdapter data = new SqlDataAdapter("select * from Student", connection);//
                DataTable dtaTble = new DataTable();//data table instance is created 

                connection.Open();//connection is been established
                data.Fill(dtaTble);
                Console.WriteLine("----------------------------------------");
                foreach (DataRow row in dtaTble.Rows)
                {
                    Console.WriteLine(row["Id"]+ " ," +row["Name"] + ",  " + row["Email"] + ",  " + row["Mobile"]);
                }
                DataTable OrginalTable = new DataTable();
                data.Fill(OrginalTable);
                Console.WriteLine("--------------------------Original Data Table---------------------");
                foreach (DataRow row in OrginalTable.Rows)
                {
                    Console.WriteLine(row["Id"] + " ," + row["Name"] + ",  " + row["Email"] + ",  " + row["Mobile"]);
                }
                Console.WriteLine();
                Console.WriteLine("--------------------------copyDataTable-------------------------");
                DataTable copyDataTable = OrginalTable.Copy();
                if (copyDataTable != null)
                {
                    foreach (DataRow row in copyDataTable.Rows)
                    {
                        Console.WriteLine(row["Id"] + " ," + row["Name"] + ",  " + row["Email"] + ",  " + row["Mobile"]);
                    }
                }

                foreach (DataRow row in OrginalTable.Rows)
                {
                    if (Convert.ToInt32(row["Id"]) == 103)
                    {
                         row.Delete();
                        Console.WriteLine("Row Deleted");
                    }
                    //else
                    //{
                    //    Console.WriteLine("row does not exists");
                    //}
                }
                    OrginalTable.AcceptChanges();
                Console.WriteLine("----------------------after deleting  a row---------------");
                foreach (DataRow row in OrginalTable.Rows)
                    {
                    Console.WriteLine(row["Name"] + ", " + row["Email"] + ",  " + row["Mobile"]);

                    }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Log.Error(ex.Message, "some error occured");
            }
        }
    }
}
