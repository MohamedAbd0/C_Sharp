using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace corecourses
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["name"] = Session["admin"] =Session["id"]= null;
        }

        protected void chkpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtpassword.TextMode != TextBoxMode.SingleLine)
                txtpassword.TextMode = TextBoxMode.SingleLine;
            else
                txtpassword.TextMode = TextBoxMode.Password;
           
        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["courses"].ToString());
            SqlCommand cmd = new SqlCommand("select * from students ",con);
            SqlDataAdapter adabt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
                adabt.Fill(ds,"student");
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    if(item["email"].ToString()==txtemail.Text)
                    {
                        if(item["password"].ToString()==txtpassword.Text)
                        {
                            if (item["email"].ToString() =="Admin@Admin.Admin" && item["password"].ToString() == "Admin")
                            {
                                Session["admin"] = "admin";
                                Response.Redirect("admin.aspx");
                            }
                            else
                            {
                                Session["name"] = item["fname"].ToString();
                                Session["id"] = item["id"].ToString();
                                Session["admin"] = null;
                                Response.Redirect("home2.aspx");
                            }
                        }
                        else
                        {
                            Response.Write(" <script> alert('Error Password Pls enter again ');</script>");
                            break;
                        }
                    }
                }

           

        }
    }
}