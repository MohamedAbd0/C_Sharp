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
    public partial class Acount : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] ==null)
            {
                Response.Redirect("Login.aspx");
            }

           else
            {

                int id = int.Parse(Session["id"].ToString());
                DataSet ds = management.GetGataSEt("select * from students where id=" + id + "", "mydata");
                DataRow[] dr = ds.Tables["mydata"].Select("id=" + id);

                txtfname.Text = dr[0]["fname"].ToString();
                txtlname.Text = dr[0]["lname"].ToString();
                txtage.Text = dr[0]["age"].ToString();
                txtpassword.Text = dr[0]["password"].ToString();
                txtemail.Text = dr[0]["email"].ToString();
                txtcollage.Text = dr[0]["collage"].ToString();
               
            }
          
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Session["id"].ToString());
            DataSet ds = management.GetGataSEt("select * from students", "update");
            DataRow[] dr = ds.Tables["update"].Select("id=" + id);
             dr[0]["fname"]= txtfname.Text;
             dr[0]["lname"]=txtlname.Text;
             dr[0]["age"]= txtage.Text;
             dr[0]["password"]=txtpassword.Text ;
             dr[0]["email"]= txtemail.Text ;
             dr[0]["collage"]=txtcollage.Text;
             dr[0]["Gender"] = rbtgender.SelectedValue.ToString();

             management.saveTOdataBase(ds, "update");
             Response.Write(" <script> alert(' Update Done.....');</script>");
            

        }
    }
}