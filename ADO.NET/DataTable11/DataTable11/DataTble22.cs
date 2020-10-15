using Serilog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataTable11
{
    class DataTble22
    {
        public void dataTable()
        {
            try
            {
                //Creating data table instance
                DataTable dataTable = new DataTable("Student");
                //Add the DataColumn using all properties
                DataColumn Id = new DataColumn("ID");
                Id.DataType = typeof(int);
                Id.Unique = true;
                Id.AllowDBNull = false;
                Id.Caption = "Student_ID";
                dataTable.Columns.Add(Id);

                //Add the DataColumn few properties
                DataColumn Name = new DataColumn("Name");
                Name.MaxLength = 50;
                Name.AllowDBNull = false;
                dataTable.Columns.Add(Name);

                //Add the DataColumn using defaults
                DataColumn Email = new DataColumn("Email");
                Email.AllowDBNull = true;
                dataTable.Columns.Add(Email);

                //Setting the Primary Key
                dataTable.PrimaryKey = new DataColumn[] { Id };

                //Add New DataRow by creating the DataRow object
                DataRow row1 = dataTable.NewRow();
                row1["Id"] = 101;
                row1["Name"] = "BizRunTime";
                row1["Email"] = "BizRunTime@mail.com";
                dataTable.Rows.Add(row1);
                //Adding new DataRow by simply adding the values
                dataTable.Rows.Add(102, "kevin", "kevin@mail.com");

                //Add New DataRow by creating the DataRow object
                 DataRow row3 = dataTable.NewRow();
                row3["Id"] = 103;
                row3["Name"] = "Anu";
                //row3["email"] = "";
                dataTable.Rows.Add(row3);

                foreach (DataRow row in dataTable.Rows)
                {
                    Console.WriteLine(row["Id"] + ",  " + row["Name"] + ",  " + row["Email"]);
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
