using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace corecourses
{
    public partial class Home2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            HyperLink1.Text ="Update Profile "+ Session["name"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["sname"] = TextBox1.Text;
            Response.Redirect("MyCourse.aspx?type=search");
        }
    }
}