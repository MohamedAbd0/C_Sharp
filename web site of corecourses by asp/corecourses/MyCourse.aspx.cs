using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace corecourses
{
    public partial class MyCourse : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
         
            

           if( Request.QueryString["type"].ToString()=="search")
           {
               try
               {
                   
                   DataSet dss = management.GetGataSEt("select id , name , time ,trainer ,detalis from courses where name='" + Session["sname"]+ "'", "searshcourse");
                   DataRow[] drs = dss.Tables["searshcourse"].Select("name='" + Session["sname"].ToString()+"'");
                   lblname.Text = drs[0]["name"].ToString();
                   lbltime.Text = drs[0]["time"].ToString();
                   lbltrainer.Text = drs[0]["trainer"].ToString();
                   lbldes.Text = drs[0]["detalis"].ToString();
               }
               catch (Exception)
               {
                  
                   Response.Write(" <script> alert('This Course Not Found ');</script>");
                   Response.Redirect("Home2.aspx");
                  
               }
              

           }
           else
           {
               int id = int.Parse(Request.QueryString[0].ToString());
               DataSet ds = management.GetGataSEt("select id , name , time ,trainer ,detalis from courses where id=" + id + "", "onecourse");
               DataRow[] dr = ds.Tables["onecourse"].Select("id=" + id);
               lblname.Text = dr[0]["name"].ToString();
               lbltime.Text = dr[0]["time"].ToString();
               lbltrainer.Text = dr[0]["trainer"].ToString();
               lbldes.Text = dr[0]["detalis"].ToString();
           }



        }
    }
}