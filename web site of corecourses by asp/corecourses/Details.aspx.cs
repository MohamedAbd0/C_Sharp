using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace corecourses
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblnameofcat.Text = Request.QueryString["name"].ToString();
            HyperLink1.Text = "Update Profile " + Session["name"].ToString();
        }

       
        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            Response.Redirect("MyCourse.aspx?id=" + e.CommandName+"&type=findcourse");
            
           
        }

       

    }
}