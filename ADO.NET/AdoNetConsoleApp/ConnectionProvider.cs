using System;

using System.Data.SqlClient;


namespace AdoNetConsoleApp
{
    class ConnectionProvider
    {
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                string connectionString = "data source=.; database=Employee; integrated security=SSPI";
                con = new SqlConnection(connectionString);
                string query1 = "create table Employee_Details (id int not null,name varchar(20),email varchar(10),join_date date)";
                string query2 = "insert into Employee_Details (id, name,email, join_date) values (1,'Ronaldo','ron@n.com','2020-10-01')";
                string query3 = "insert into Employee_Details (id, name,email, join_date) values (3,'Zlatan','zltn@9.com','2020-10-02')";
                string query4 = "insert into Employee_Details (id, name,email, join_date) values (4,'Neymer','ney@10.com','2020-10-03')";
                string q5 = "delete from Employee_Details where id=2";
                SqlCommand command = new SqlCommand(query3, con);
                con.Open();
                int x = command.ExecuteNonQuery();
                if (x > 0)
                {
                    Console.WriteLine("Successfully query executed :-) ");
                }
                else
                {
                    Console.WriteLine("Query not  executed...!!!");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                Console.WriteLine("Opps!! something went wrong");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
