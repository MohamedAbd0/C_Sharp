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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["courses"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into students( fname ,lname, age , password , email ,collage ,gender ) values(@fname,@lname,@age,@password,@email,@collage,@gender) ";
            cmd.Parameters.AddWithValue("@fname", txtfname.Text);
            cmd.Parameters.AddWithValue("@lname", txtlname.Text);
            cmd.Parameters.AddWithValue("@age", txtage.Text);
            cmd.Parameters.AddWithValue("@password", txtpassword.Text);
            cmd.Parameters.AddWithValue("@email", txtemail.Text);
            cmd.Parameters.AddWithValue("@collage", txtcollage.Text);
            cmd.Parameters.AddWithValue("@gender", rbtgender.SelectedValue);
            cmd.Connection = con;
                con.Open();
              cmd.ExecuteNonQuery();
           
                con.Close();
                Session["name"] = txtfname.Text + " " + txtlname.Text;
                Response.Redirect("home.aspx");


        }
     }

        
}


       
   
