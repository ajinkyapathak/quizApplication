using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quiz
{
    public partial class result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try {
                Label3.Text = Session["name"].ToString();
                Label2.Text = Session["score"].ToString();
                // Label5.Text = Session["wrong"].ToString();
                // Session.RemoveAll();
                Session.Abandon();
            }
            catch(Exception err) { Response.Redirect("index.aspx"); }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Session.Abandon();
            try
            {
                //Session.Abandon();
                Response.Redirect("index.aspx");
            }
            catch(Exception err) { Response.Redirect("index.aspx"); }
        }
    }
}