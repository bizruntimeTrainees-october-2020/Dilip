using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Serilog;
using System.Dynamic;
using System.ComponentModel.Design;

namespace LoggersSeri
{
    class ActiveData
    {
        public void SubDivison()
        {
            SqlConnection connection = null;

            try
            {
                string clientConection = "data source =.; database = HR; integrated security = SSPI";
                connection = new SqlConnection(clientConection);
                //string query1 = "create table sell(salesID int not null PRIMARY KEY,salesDate date,salesPersonName varchar(20) not null,salesItemName varchar(30))";

                //string query2 = "insert into sell(salesID,salesDate,salesPersonName,salesItemName) values (101,'10/02/2020','rama','geometryBox')";
                //string query3 = "select * from sell where salesID =103";
                //string query4 = "create table sell(salesID int not null
                //string query1 = "CREATE TABLE Candidates( iD INT PRIMARY KEY IDENTITY,fullname VARCHAR(30) not null)";
                //string query2 = "CREATE TABLE Employees(id INT PRIMARY KEY IDENTITY,fullname VARCHAR(30) not null)";
                //string query3 = "insert into Candidates(ID,fullname) values (101,'akash'),(102,'arun'),(103,'manu'),(104,'mahi')";
                //string query4 = "insert into Employees(id,fullname) values(101,'akash'),(102,'pradha'),(103,'suresh')";
                string query5 = " SELECT c.id  as candidate_id, c.fullname as candidate_name , e.id  as employee_id, e.fullname as employee_name FROM Candidates  as c INNER JOIN Employees as e ON e.id = c.iD ";
                Console.WriteLine("done");//INNER JOIN
                string query6 = "SELECT  c.id as candidate_id,c.fullname as candidate_name,e.id  as employee_id, e.fullname as employee_name FROM Candidates as c LEFT JOIN Employees e ON e.id = c.id ";


                //SqlCommand command = new SqlCommand(query1, connection);
                SqlCommand command = new SqlCommand(query5, connection);
                //SqlCommand command = new SqlCommand(query2, connection);
                //SqlCommand command = new SqlCommand(query3, connection);
                //SqlCommand command = new SqlCommand(query4, connection);
                connection.Open();
               int x= command.ExecuteNonQuery();
                Console.WriteLine("inserted values");

                //SqlDataReader reader = command.ExecuteReader();//reading a table inside database
                //while (reader.Read())
                //{
                //    int salesID = reader.GetInt32(0);
                //    DateTime salesDate = reader.GetDateTime(1);
                //    string salesPersonName = reader.GetString(2);
                //    string salesItemName = reader.GetString(3);
                //    Console.WriteLine(salesID + "," + salesDate + "," + salesPersonName + "," + salesItemName);
                //}

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Log.Error(ex.Message, "some error occured");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
