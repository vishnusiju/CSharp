using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Odbc;


namespace ADO.NETWA
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = "data source=.; database = Simple; integrated security=SSPI";
            SqlConnection con = new SqlConnection(CS);
            try
            {
                SqlConnection cmd = new SqlConnection("SELECT * FROM Employee", con);
                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();

            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
            
        }
    }
}