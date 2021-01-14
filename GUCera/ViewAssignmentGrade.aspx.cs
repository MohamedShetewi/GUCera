    using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class ViewAssignmentGrade : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
                Response.Redirect("Login.aspx");
            else if (Session["type"].Equals("1"))
                Response.Redirect("AdminHomePage.aspx");
            else if (Session["type"].Equals("0"))
                Response.Redirect("InstructorHomePage.aspx");
            errorMessage.Visible = false;
            grade.Visible = false;
        }
        protected void viewButton_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            try
            {
                int _courseID = Int16.Parse(courseID.Text);
                String _assignmentType = assignmenttype.Text;
                int _assignmentNum = Int16.Parse(assignmentnumber.Text);
                int _ID = ((int)Session["user"]) ;

                SqlCommand viewAssignGrades = new SqlCommand("viewAssignGrades", conn);
                viewAssignGrades.CommandType = CommandType.StoredProcedure;

                viewAssignGrades.Parameters.Add(new SqlParameter("@cid", _courseID));
                viewAssignGrades.Parameters.Add(new SqlParameter("@assignType", _assignmentType));
                viewAssignGrades.Parameters.Add(new SqlParameter("@assignnumber", _assignmentNum));
                viewAssignGrades.Parameters.Add(new SqlParameter("@Sid", _ID));
               
                SqlParameter _grade = viewAssignGrades.Parameters.Add("@assignGrade", SqlDbType.Int);
                _grade.Direction = ParameterDirection.Output;

                conn.Open();
                viewAssignGrades.ExecuteNonQuery();
                conn.Close();
                grade.Visible = true;
                grade.Text = _grade.Value.ToString();

            }
            catch (System.FormatException)
            {
                grade.Visible = false;
                errorMessage.Visible = true;
            }
            catch (System.OverflowException)
            {
                grade.Visible = true;
                errorMessage.Visible = true;
            }
            catch (System.Data.SqlClient.SqlException)
            {
                grade.Visible = true;
                errorMessage.Visible = true;
            }
        }
    }
}