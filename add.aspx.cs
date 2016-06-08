using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quiz
{
    public partial class add : System.Web.UI.Page
    {
        //string connectionString = "Data Source = orcl; User Id=C##QUIZ; passowrd=quiz;";
        String connectionString = "Data Source= (DESCRIPTION =" +
     "(ADDRESS = (PROTOCOL = TCP)(HOST = 10.7.1.15)(PORT = 1521))" +
     "(CONNECT_DATA ="
       + "(SERVER = DEDICATED)" +
       "(SERVICE_NAME = pdborcl)));" + "User Id=2013BCS013; password=2013BCS013;";
        OracleConnection con = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                con = new OracleConnection(connectionString);
                //  con.ConnectionString = connectionString;
                con.Open();
            }
            catch(Exception err) { Console.Write("Error:" + err); }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try {
                string question = TextBox5.Text;
                string op1 = TextBox1.Text;
                string op2 = TextBox2.Text;
                string op3 = TextBox3.Text;
                string op4 = TextBox4.Text;
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "select count(*) from questions";
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                int n = dr.GetInt32(0);
                n = n + 1;
                cmd.CommandText = "insert into questions values(:q_id,:question,:opt1,:opt2,:opt3,:opt4,:ans,:marks)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add(new OracleParameter("q_id", n));
                cmd.Parameters.Add(new OracleParameter("question", question));
                cmd.Parameters.Add(new OracleParameter("opt1", op1));
                cmd.Parameters.Add(new OracleParameter("opt2", op2));
                cmd.Parameters.Add(new OracleParameter("opt3", op3));
                cmd.Parameters.Add(new OracleParameter("opt4", op4));
                cmd.Parameters.Add(new OracleParameter("ans", DropDownList1.SelectedValue));
                cmd.Parameters.Add(new OracleParameter("marks", TextBox6.Text));
                cmd.ExecuteNonQuery();

                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
            }
            catch(Exception err) { Response.Write("Error: " + err); }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}