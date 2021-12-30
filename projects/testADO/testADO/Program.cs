/*
using System;
using System.Data.SqlClient;


namespace Test
{
    class Program
    {
        readonly string ConnectionString = @"Data Source=DESKTOP-D1T721P\SQLEXPRESS;Initial Catalog=test;Integrated Security=True";
        public void Table()
        {
            SqlConnection conn = new SqlConnection();

            
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-D1T721P\SQLEXPRESS;Initial Catalog=test;Integrated Security=True");
                //conn.ConnectionString = "Data Source=DESKTOP-D1T721P\SQLEXPRESS;Initial Catalog=test;Integrated Security=True"
                conn.Open();
                SqlCommand Command = new SqlCommand("CREATE TABLE TestTable(id int not null, name varchar(50), email varchar(50))", conn);                
                Command.ExecuteNonQuery();
                

                Console.WriteLine("Table Done");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error" + e.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        public void Insert()
        {
            SqlConnection conn;

            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-D1T721P\SQLEXPRESS;Initial Catalog=test;Integrated Security=True");
                //conn.ConnectionString = "Data Source=DESKTOP-D1T721P\SQLEXPRESS;Initial Catalog=test;Integrated Security=True"
                conn.Open();

                SqlCommand Command = new SqlCommand(@"INSERT INTO TestTable (id, name, email) VALUES ('102', 'kamesh', 'abc@ghi.com')", conn);
                int rowsAffected = Command.ExecuteNonQuery();
                Console.WriteLine("Inserted Rows = " + rowsAffected);
                conn.Close();
                Console.WriteLine("Data inserted!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }


        }

        public void Fetch()
        {
            SqlConnection conn;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-D1T721P\SQLEXPRESS;Initial Catalog=test;Integrated Security=True");
                //conn.ConnectionString = "Data Source=DESKTOP-D1T721P\SQLEXPRESS;Initial Catalog=test;Integrated Security=True"
                conn.Open();

                SqlCommand Command = new SqlCommand("SELECT * FROM TestTable", conn);



                SqlDataReader DataString = Command.ExecuteReader();      // DataReader read
                //Console.WriteLine(DataString.HasRows);

                while (DataString.Read())      // Iterating Data using loop  
                {
                      
                    Console.WriteLine(DataString["id"] + " " + DataString["name"] + " " + DataString["email"]);       // show data
                    //Console.WriteLine(DataString[0] + " " + DataString[1] + " " + DataString[2]);
                }
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error" + e.Message);
            }
        }

        public void Delete()
        {
            //SqlConnection conn = new SqlConnection();

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    SqlCommand Command = new SqlCommand("DELETE FROM TestTable WHERE id = '101'", conn);
                    conn.Open();
                    Command.ExecuteNonQuery();
                    Console.WriteLine("Data Deleted!");
                }
                 //   conn = new SqlConnection(ConnectionString);
                //conn.ConnectionString = "Data Source=DESKTOP-D1T721P\SQLEXPRESS;Initial Catalog=test;Integrated Security=True"
                //conn.Open();

                //SqlCommand Command = new SqlCommand("DELETE FROM TestTable WHERE id = '101'", conn);

                //Command.ExecuteNonQuery();
                //Console.WriteLine("Data Deleted!");

                
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR" + e.Message);
            }
            //finally
            //{
             //   conn.Close();
            //}
        }


        static void Main()
        {
            Program p = new Program();
            //p.Table();
            //p.Insert();
            //p.Fetch();
            //p.Delete();
        }

    }
}


*/


using System;
using System.Data.SqlClient;
using System.Data;

namespace Test
{
    class Program
    {
        string strr = @"Data Source = DESKTOP-D1T721P\SQLEXPRESS; Initial Catalog = test; Integrated Security = True";
        SqlConnection conn = new SqlConnection();
        public void Adaptr()
        {   
            
            try
            {
                conn = new SqlConnection(strr);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TestTable", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                Console.WriteLine("Using DataTable ");
                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine(row[0] + " " + row[1] + " " + row[2]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        static void Main()
        {
            Program p = new Program();
            p.Adaptr();
        }
    }
}
