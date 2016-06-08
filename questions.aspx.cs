using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quiz
{
    public partial class questions : System.Web.UI.Page
    {
        String connectionString = "Data Source= (DESCRIPTION =" +
     "(ADDRESS = (PROTOCOL = TCP)(HOST = 10.7.1.15)(PORT = 1521))" +
     "(CONNECT_DATA ="
       + "(SERVER = DEDICATED)" +
       "(SERVICE_NAME = pdborcl)));" + "User Id=2013BCS013; password=2013BCS013;";
        OracleConnection con = null;
       private static int n = 1;
        int m = 0;
       private static int correct = 0, incorrect = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!SM1.IsInAsyncPostBack)
                Session["timeout"] = DateTime.Now.AddSeconds(300).ToString();
      
            try
            {
                con = new OracleConnection(connectionString);
                //  con.ConnectionString = connectionString;
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "select count(*) from questions";
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                m = dr.GetInt32(0);

                cmd.CommandText = "select question FROM questions where q_id=" + n;
                dr = cmd.ExecuteReader();
                dr.Read();
                Label1.Text = dr.GetString(0);

                cmd.CommandText = "SELECT opt1 FROM questions where q_id=" + n;
                dr = cmd.ExecuteReader();
                dr.Read();
                RadioButton1.Text = dr.GetString(0);


                cmd.CommandText = "SELECT opt2 FROM questions where q_id=" + n;
                dr = cmd.ExecuteReader();
                dr.Read();
                RadioButton2.Text = dr.GetString(0);

                cmd.CommandText = "SELECT opt3 FROM questions where q_id=" + n;
                dr = cmd.ExecuteReader();
                dr.Read();
                RadioButton3.Text = dr.GetString(0);

                cmd.CommandText = "SELECT opt4 FROM questions where q_id=" + n;
                dr = cmd.ExecuteReader();
                dr.Read();
                RadioButton4.Text = dr.GetString(0);

                
                if (n < 2)
                {
                    Button1.Enabled = false;
                    Button1.CssClass = "btn-primary disabled";
                }
                else
                {
                    Button1.Enabled = true;
                    Button1.CssClass = "btn-primary active";
                }
            }
            catch (Exception err) { Response.Write("Error:" + err); }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                n++;
                if(n==m)
                {
                    Button3.Enabled = false;
                    Button3.CssClass = "btn-success disabled";
                }
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "select question FROM questions where q_id="+n;
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                Label1.Text = dr.GetString(0);

                cmd.CommandText = "SELECT opt1 FROM questions where q_id="+n;
                dr = cmd.ExecuteReader();
                dr.Read();
                RadioButton1.Text = dr.GetString(0);


                cmd.CommandText = "SELECT opt2 FROM questions where q_id="+n;
                dr = cmd.ExecuteReader();
                dr.Read();
                RadioButton2.Text = dr.GetString(0);

                cmd.CommandText = "SELECT opt3 FROM questions where q_id="+n;
                dr = cmd.ExecuteReader();
                dr.Read();
                RadioButton3.Text = dr.GetString(0);

                cmd.CommandText = "SELECT opt4 FROM questions where q_id="+n;
                dr = cmd.ExecuteReader();
                dr.Read();
                RadioButton4.Text = dr.GetString(0);

                
               
            }
            catch(Exception err) { Response.Write("Error: " + err); }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session.Add("score", correct);
            Session.Add("wrong", incorrect);
            Response.Redirect("result.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                if(n<2)
                {
                    Button1.Enabled = false;
                    Button1.CssClass="btn-primary disabled";
                }
                else
                {
                    Button1.Enabled = true;
                    Button1.CssClass = "btn-primary active";
                }
                n--;
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "select question FROM questions where q_id=" + n;
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                Label1.Text = dr.GetString(0);

                cmd.CommandText = "SELECT opt1 FROM questions where q_id=" + n;
                dr = cmd.ExecuteReader();
                dr.Read();
                RadioButton1.Text = dr.GetString(0);


                cmd.CommandText = "SELECT opt2 FROM questions where q_id=" + n;
                dr = cmd.ExecuteReader();
                dr.Read();
                RadioButton2.Text = dr.GetString(0);

                cmd.CommandText = "SELECT opt3 FROM questions where q_id=" + n;
                dr = cmd.ExecuteReader();
                dr.Read();
                RadioButton3.Text = dr.GetString(0);

                cmd.CommandText = "SELECT opt4 FROM questions where q_id=" + n;
                dr = cmd.ExecuteReader();
                dr.Read();
                RadioButton4.Text = dr.GetString(0);

            }
            catch (Exception err) { Response.Write("Error: " + err); }
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {

                int p = n;
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT ans FROM questions where q_id=" + p;
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                int ans1 = 0;
                if (RadioButton1.Checked == true)
                {
                    ans1 = 1;
                }
                else if (RadioButton2.Checked == true)
                {
                    ans1 = 2;
                }
                else if (RadioButton3.Checked == true)
                {
                    ans1 = 3;
                }
                else if (RadioButton4.Checked == true)
                {
                    ans1 = 4;
                }


                if (ans1 == dr.GetInt32(0))
                {
                    //Label6.Text = "Correct";
                    correct++;
                }
                else
                {
                    // Label6.Text = "Incorrect";
                    incorrect++;
                }

            }
            catch(Exception err) { Response.Write("err" + err); }
        }

        protected void timer1_tick(object sender, EventArgs e)
        {
            try {
                if (0 > DateTime.Compare(DateTime.Now,
                DateTime.Parse(Session["timeout"].ToString())))
                {
                    lblTimer.Text = "Number of Seconds Left: " +
                    ((Int32)DateTime.Parse(Session["timeout"].
                    ToString()).Subtract(DateTime.Now).TotalSeconds).ToString();

                    if ("0".Equals(((Int32)DateTime.Parse(Session["timeout"].ToString()).Subtract(DateTime.Now).TotalMinutes).ToString()))
                    {
                        Response.Redirect("result.aspx");
                    }
                }
            }
            catch(Exception err) { Console.Write("" + err);  }
        }
    }
}