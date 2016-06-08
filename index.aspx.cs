using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Quiz
{
    public partial class index : System.Web.UI.Page
    {
        OracleConnection con = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            String connectionString = "Data Source= (DESCRIPTION =" +
     "(ADDRESS = (PROTOCOL = TCP)(HOST = 10.7.1.15)(PORT = 1521))" +
     "(CONNECT_DATA ="
       + "(SERVER = DEDICATED)" +
       "(SERVICE_NAME = pdborcl)));" + "User Id=2013BCS013; password=2013BCS013;";
            try
            {
                con = new OracleConnection(connectionString);
                con.Open();
            }
            catch (Exception er) { }

           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            Session.Add("name",name);
            Response.Redirect("questions.aspx");
        }
    }
}