using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.DataAccess.Client;
using System.Data;

namespace Quiz
{
    public partial class admin : System.Web.UI.Page
    {
        OracleConnection con = null;
        // String connectionString = "Data Source = orcl; User Id=C##quiz; passowrd=quiz;";
        String connectionString = "Data Source= (DESCRIPTION =" +
     "(ADDRESS = (PROTOCOL = TCP)(HOST = 10.7.1.15)(PORT = 1521))" +
     "(CONNECT_DATA ="
       + "(SERVER = DEDICATED)" +
       "(SERVICE_NAME = pdborcl)));" + "User Id=2013BCS013; password=2013BCS013;";
        protected void Page_Load(object sender, EventArgs e)
        {
           
            try
            {
                con = new OracleConnection(connectionString);
              //  con.ConnectionString = connectionString;
                con.Open();
            }
            catch (Exception er) { Console.Write("error" + er); }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                string username = TextBox1.Text;
                string pass = TextBox2.Text;
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = " select * from login where username='"+ username +"'";
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;              
                OracleDataReader dr = cmd.ExecuteReader();
               // Response.Redirect("add.aspx");
                dr.Read();
                string pwd = dr.GetString(2).ToString();
                if (pass.Equals(pwd))
                {
                    Console.Write("admin con success");
                    Response.Redirect("add.aspx");
                }
                else
                {
                    Response.Write("invalid username or passowrd");
                    TextBox2.Text = "";
                }
            }
            catch (Exception err) {
                Response.Write("error" + err);
            }
        }
    }
}