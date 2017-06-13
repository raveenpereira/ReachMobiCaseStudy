using System;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace SecondCS.DAO
{
    public class MyDB
    {
        public MyDB(int zip, String email, String verified)
        {
            Console.WriteLine("object created");
			string myConnString = null;
			myConnString = "server=reachmobi.coclaorf0p54.eu-central-1.rds.amazonaws.com; user id=root; password=reachmobi; database=reachmobi; pooling=false;";
			try
			{
                MySqlConnection conn = new MySqlConnection(myConnString);
				conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO User(zip,email,verified) VALUES(@zip,@email,@verified)";
				cmd.Prepare();

				cmd.Parameters.AddWithValue("@zip", zip);
				cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@verified", verified);


			
                cmd.ExecuteNonQuery();
                conn.Close();
				
			}
			catch
			{
                Console.WriteLine("unable to connect");
				
			}
        }
        public MyDB(int zip, String verified){
            Console.WriteLine("overloaded constructor");
            string myConnString = null;
			myConnString = "server=reachmobi.coclaorf0p54.eu-central-1.rds.amazonaws.com; user id=root; password=reachmobi; database=reachmobi; pooling=false;";
			try{
                MySqlConnection conn = new MySqlConnection(myConnString);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText="INSERT INTO User(zip,verified) VALUES(@zip,@verified)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@zip",zip);
                cmd.Parameters.AddWithValue("@verified",verified);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch{
                Console.WriteLine("unable to connect");
            }
		}
    }
}
