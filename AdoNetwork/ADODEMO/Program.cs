using System;
using System.Data.SqlClient;
using System.Data.OleDb;


namespace SimpleAdo
{
    class Program
    {
        static void Main(string[] args)
        {
            adoclass AC = new adoclass();
            AC.AdoMeth();
        }
        class adoclass
        {
            public void AdoMeth()
            {
                string connectionString =
                "Data Source=(local);Initial Catalog=student;"
                + "Integrated Security=true";

                // Provide the query string with a parameter placeholder.
                string queryString =
                    "SELECT person_id, first_name, last_name, email_id from dbo.person ";

                int paramValue = 5;


                //to establist the connection using oledbconnection
                using (OleDbConnection connection =
                        new OleDbConnection(connectionString))
                {
                    // Create the Command and Parameter objects.
                    OleDbCommand command = new OleDbCommand(queryString, connection);
                    command.Parameters.AddWithValue("last_name", paramValue);
                    try
                    {
                        connection.Open();
                        OleDbDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Console.WriteLine("\t{0}\t{1}\t{2}",
                                reader[0], reader[1], reader[2]);
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Console.ReadLine();



                }
            }
        }
    }
}


