using System;
using System.Data;
using System.Web;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace createdatabase
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool IsPostBack = false;
            if (!IsPostBack)
            {
                DataSet ds = CreateDataSet();
                //object GridView1 = null;
                GridView1.DataSource = ds.Tables["Student"];
                GridView1.DataBind();
            }
        }

        private DataSet CreateDataSet()
        {
            //creating a DataSet object for tables
            DataSet dataset = new DataSet();

            // creating the student table
            DataTable Students = CreateStudentTable();
            dataset.Tables.Add(Students);
            return dataset;
        }

        private DataTable CreateStudentTable()
        {
            DataTable Students = new DataTable("Student");

            // adding columns
            AddNewColumn(Students, "System.Int32", "StudentID");
            AddNewColumn(Students, "System.String", "StudentName");
            AddNewColumn(Students, "System.String", "StudentCity");

            // adding rows
            AddNewRow(Students, 1, "M H Kabir", "Kolkata");
            AddNewRow(Students, 1, "Shreya Sharma", "Delhi");
            AddNewRow(Students, 1, "Rini Mukherjee", "Hyderabad");
            AddNewRow(Students, 1, "Sunil Dubey", "Bikaner");
            AddNewRow(Students, 1, "Rajat Mishra", "Patna");

            return Students;
        }

        private void AddNewColumn(DataTable table, string columnType, string columnName)
        {
            DataColumn column = table.Columns.Add(columnName, Type.GetType(columnType));
        }

        //adding data into the table
        private void AddNewRow(DataTable table, int id, string name, string city)
        {
            DataRow newrow = table.NewRow();
            newrow["StudentID"] = id;
            newrow["StudentName"] = name;
            newrow["StudentCity"] = city;
            table.Rows.Add(newrow);
        }
    }
}








//namespace AdoNet
//{
//    class Program
//    {
//        static void Main()
//        {
//            string connectionString =
//                "Data Source=(local);Initial Catalog=master;"
//                + "Integrated Security=true";
//            string queryString =
//                "SELECT person_id, first_name FROM dbo.person";
//            using (OracleConnection connection =
//                       new OracleConnection(connectionString))
//            {
//                OracleCommand command = connection.CreateCommand();
//                command.CommandText = queryString;

//                try
//                {
//                    connection.Open();

//                    OracleDataReader reader = command.ExecuteReader();

//                    while (reader.Read())
//                    {
//                        Console.WriteLine("\t{0}\t{1}",
//                            reader[0], reader[1]);
//                    }
//                    reader.Close();
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine(ex.Message);
//                }
//            }
//        }
//    }

//}





//namespace AdoNet
//{
//    class Program
//    {
//        static void Main(String[] args)
//        {
//            string connectionString =
//                "Data Source=(local);Initial Catalog=student;"
//                + "Integrated Security=true";

//            // Provide the query string with a parameter placeholder.
//            string queryString =
//                "SELECT person_id, first_name, last_name, email_id from dbo.person";


//            // Specify the parameter value.
//            int paramValue = 5;

//            // Create and open the connection in a using block. This
//            // ensures that all resources will be closed and disposed
//            // when the code exits.
//            using (SqlConnection connection =
//                new SqlConnection(connectionString))
//            {
//                // Create the Command and Parameter objects.
//                SqlCommand command = new SqlCommand(queryString, connection);
//                command.Parameters.AddWithValue("", paramValue);

//                // Open the connection in a try/catch block.
//                // Create and execute the DataReader, writing the result
//                // set to the console window.
//                try
//                {
//                    connection.Open();
//                    SqlDataReader reader = command.ExecuteReader();
//                    while (reader.Read())
//                    {
//                        Console.WriteLine("\t{0}\t{1}\t{2}",
//                            reader[0], reader[1], reader[2]);
//                    }
//                    reader.Close();
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine(ex.Message);
//                }
//                Console.ReadLine();
//            }
//        }

//    }
//}

