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
    public partial class admin : System.Web.UI.Page
    {
        DataSet ds;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["admin"] == null)
            {
                Session["name"] = null;
                Response.Redirect("login.aspx");
            }
            else
           
           {
                ds = management.GetGataSEt("select * from category", "category");

                fillddlcategory();
                FillddlNameCategory();
                fillddlcoursesname();
                fillddlStudentName();
            }
        }
           

        private void fillddlStudentName()
        {
            ds = management.GetGataSEt("select fname+SPACE(1)+lname 'name',id from students", "studentname");
            DDLStudentName.DataSource = ds.Tables["studentname"];
            DDLStudentName.DataTextField = "name";
            DDLStudentName.DataValueField = "id";
            DDLStudentName.DataBind();

        }

        private void fillddlcoursesname()
        {
            ds = management.GetGataSEt("select * from courses", "course");
            DDLCourseName.DataSource = ds.Tables["course"];
            DDLCourseName.DataTextField = "name";
            DDLCourseName.DataValueField = "id";
            DDLCourseName.DataBind();
        }
        private void fillddlcategory()
        {
            DDLCategory.DataSource = ds.Tables["category"];
            DDLCategory.DataTextField = "name";
            DDLCategory.DataValueField = "id";
            DDLCategory.DataBind();
        }
        private void FillddlNameCategory()
        {
            ddlnamecategory.DataSource = ds.Tables["category"];
            ddlnamecategory.DataTextField = "name";
            ddlnamecategory.DataValueField = "id";
            ddlnamecategory.DataBind();
        }

        protected void btnAddCourse_Click(object sender, EventArgs e)
        {
            ds = management.GetGataSEt("select * from courses", "course");
            int id_course = int.Parse(ds.Tables["course"].Rows[ds.Tables["course"].Rows.Count - 1]["id"].ToString()) + 1;
            management.New_Course("course", id_course, txtCname.Text, int.Parse(txtCTime.Text), txtCTrainer.Text, txtCDetails.Text, int.Parse(DDLCategory.SelectedValue.ToString()), txttutorialcourse.Text);
            management.saveTOdataBase(ds, "course");
            fillddlcoursesname();
            cleartxtboxOfAddCourse();
            msg("Add Course Done.....");

        }

        private void cleartxtboxOfAddCourse()
        {
            txtCDetails.Text = txtCname.Text = txtCTime.Text = txtCTrainer.Text = string.Empty;
            DDLCategory.SelectedValue.DefaultIfEmpty();

        }
        private void msg(string msg)
        {
            Response.Write(" <script> alert('" + msg + "');</script>");
        }

        protected void DDLCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ds = management.GetGataSEt("select * from courses", "course");

            DataRow[] dr = ds.Tables["course"].Select("id=" + int.Parse(DDLCourseName.SelectedValue.ToString()));
            txtCname.Text = dr[0]["name"].ToString();
            txtCTime.Text = dr[0]["time"].ToString();
            txtCTrainer.Text = dr[0]["trainer"].ToString();
            txtCDetails.Text = dr[0]["detalis"].ToString();
            ds = management.GetGataSEt("select * from category", "category");

            DataRow[] dr_category = ds.Tables["category"].Select("id=" + int.Parse(dr[0]["category_id"].ToString()));
            DDLCategory.SelectedItem.Text = dr_category[0]["name"].ToString();
            // DDLCourseName.SelectedValue = dr_category[0]["id"].ToString();

        }

        protected void btnUpate_Click(object sender, EventArgs e)
        {

            ds = management.GetGataSEt("select * from courses", "course");
            DataRow[] dr = ds.Tables["course"].Select("id=" + int.Parse(DDLCourseName.SelectedValue.ToString()));
            dr[0]["name"] = txtCname.Text;
            dr[0]["time"] = txtCTime.Text;
            dr[0]["trainer"] = txtCTrainer.Text;
            dr[0]["detalis"] = txtCDetails.Text;
            dr[0]["category_id"] = DDLCategory.SelectedValue.ToString();
            management.saveTOdataBase(ds, "course");
            cleartxtboxOfAddCourse();
            msg("Update Done.....");
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            ds = management.GetGataSEt("select * from courses", "course");
            DataRow[] dr = ds.Tables["course"].Select("id=" + int.Parse(DDLCourseName.SelectedValue.ToString()));
            dr[0].Delete();
            management.saveTOdataBase(ds, "course");
            fillddlcoursesname();
            cleartxtboxOfAddCourse();
            msg("Deleted Done.....");

        }

        protected void ddlnamecategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ds = management.GetGataSEt("select * from category", "category");
            DataRow[] dr = ds.Tables["category"].Select("id=" + int.Parse(ddlnamecategory.SelectedValue.ToString()));
            txtcategoryname.Text = dr[0]["name"].ToString();
        }

        protected void btnbeletecategory_Click(object sender, EventArgs e)
        {
            ds = management.GetGataSEt("select * from category", "category");
            DataRow[] dr = ds.Tables["category"].Select("id=" + int.Parse(ddlnamecategory.SelectedValue.ToString()));
            dr[0].Delete();
            management.saveTOdataBase(ds, "category");
            txtcategoryname.Text = string.Empty;
            FillDropDownList();
        }

        private void FillDropDownList()
        {
            fillddlcategory();
            FillddlNameCategory();
        }

        protected void btnupdatecategory_Click(object sender, EventArgs e)
        {
            ds = management.GetGataSEt("select * from category", "category");
            DataRow[] dr = ds.Tables["category"].Select("id=" + int.Parse(ddlnamecategory.SelectedValue.ToString()));
            dr[0]["name"] = txtcategoryname.Text;
            management.saveTOdataBase(ds, "category");
            txtcategoryname.Text = string.Empty;
            FillDropDownList();
            msg("Update Done.....");

        }

        protected void btnaddcategory_Click(object sender, EventArgs e)
        {
            ds = management.GetGataSEt("select * from category", "category");
            int id_category = int.Parse(ds.Tables["category"].Rows[ds.Tables["category"].Rows.Count - 1]["id"].ToString()) + 1;
            management.New_Category("category", id_category, txtcategoryname.Text);
            management.saveTOdataBase(ds, "category");
            txtcategoryname.Text = string.Empty;
            FillDropDownList();
            msg("Add Category Done.....");

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ds = management.GetGataSEt("select students.id, fname+SPACE(1)+lname 'Name' ,collage,ISNULL(name,'Not Choose Course') 'Course name' from students left outer join courses on students.course_id=courses.id where students.id=" + DDLStudentName.SelectedValue + "", "studentDetails");
            GridView1.DataSource = ds.Tables["studentDetails"];
            GridView1.DataBind();
        }

        protected void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            ds = management.GetGataSEt("select * from students", "studentname");
            DataRow[] dr = ds.Tables["studentname"].Select("id=" + int.Parse(DDLStudentName.SelectedValue.ToString()));
            dr[0].Delete();
            management.saveTOdataBase(ds, "studentname");
            fillddlStudentName();
            msg("Delete Student Done ......");
            GridView1.DataSource = null;
            GridView1.DataBind();

        }
        
                protected void view1(object sender, EventArgs e )
                {
                    MultiView1.ActiveViewIndex = 0;
                }
                protected void view2(object sender, EventArgs e)
                {
                    MultiView1.ActiveViewIndex = 1;
                }
                protected void view3(object sender, EventArgs e)
                {
                    MultiView1.ActiveViewIndex = 2;
                }

                protected void DDLCategory_SelectedIndexChanged(object sender, EventArgs e)
                {

                }

                
    }
}