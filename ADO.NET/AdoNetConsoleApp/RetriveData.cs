using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AdoNetConsoleApp
{
    class RetriveData
    {
        public void RetriveDataMethod()
        {
            SqlConnection con = null;
            try
            {
                string connectionString = "data source=.; database=Sample; integrated security=SSPI";
                con = new SqlConnection(connectionString);
                con.Open();
                string query = "select * from Employee_Details";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0] + " " + reader[1] + " " + reader[2] + " " + reader[3]);
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("oops...! something went wrong");
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}