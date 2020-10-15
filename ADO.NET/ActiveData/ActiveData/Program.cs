using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Dynamic;

namespace ActiveData
{
    class Sqlconnection
    {
        static void Main(string[] args)
        {
            SqlConnection connection = null;
            try
            {
                 

                 string clientConection = "data source =.; database = productions; integrated security = SSPI";
                 connection = new SqlConnection(clientConection);
                //string q1 = "create table products (pId int not null,pName varchar(10) not null, pRating int not null)";
                //string  query2 = "insert into products(pId,pName,pRating) values (101,'arun',4)";
                //SqlCommand command = new SqlCommand(query2, connection);
                //SqlCommand command = new SqlCommand(q1, connection);
                //string query3 = "insert into products values(102,'amogh',5)";
                //SqlCommand command = new SqlCommand(query3, connection);
                //Console.WriteLine("data insert into table successfully");
                //string query4 = "insert into products values(102,'zabi',5)";
                //SqlCommand command = new SqlCommand(query4, connection);
                string query5 = "select * from products where pRating>4";
                SqlCommand command = new SqlCommand(query5, connection);
                connection.Open();//opeening connection 
                SqlDataReader reader = command.ExecuteReader();//reading a table inside database
                while (reader.Read())
                {
                    int pId = reader.GetInt32(0);
                    string pName = reader.GetString(1);
                    int pRating = reader.GetInt32(2);
                    Console.WriteLine(pId + "," + pName +"," + pRating);
                }

                Console.WriteLine("established connection");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally {
                connection.Close(); 
            }
        }
    }
}
