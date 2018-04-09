using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace corecourses
{
    public class management
    {
      static  DataSet ds;
     static SqlDataAdapter da;
       public static DataSet GetGataSEt(string stat_quary,string table_name,params SqlParameter [] paramets)
        {
           ds= new DataSet();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["courses"].ConnectionString);
            SqlCommand cmd = new SqlCommand(stat_quary,con);

            foreach (SqlParameter prm in paramets)
            {
                cmd.Parameters.Add(prm);   
            }

           da  = new SqlDataAdapter(cmd);
            da.Fill(ds, table_name);
            return ds;
        }

       public static void New_Course(string table_name, int id, string name, int time, string trainer, string details, int catg_id, string Tutorial)
       {
          DataRow newrow= ds.Tables[table_name].NewRow();
          newrow["id"] = id;
          newrow["name"] = name;
          newrow["time"] = time;
          newrow["trainer"] = trainer;
          newrow["detalis"] = details;
          newrow["category_id"] = catg_id;
          newrow["link_t"] = Tutorial;
          ds.Tables[table_name].Rows.Add(newrow);
       }


        public static void New_Category(string table_name ,int id,string name)
        {
            DataRow newrow = ds.Tables[table_name].NewRow();
            newrow["id"] = id;
            newrow["name"] = name;
            ds.Tables[table_name].Rows.Add(newrow);
        }

        public static void saveTOdataBase(DataSet D,string table_name) 
        {
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            da.Update(D, table_name);
           
           // HttpResponse.(" <script> alert('data saved.....');</script>");
        }

        
    }
}