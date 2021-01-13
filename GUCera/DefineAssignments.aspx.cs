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
    public partial class DefineAssignments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
                Response.Redirect("Login.aspx");
            else if (Session["type"].Equals("1"))
                Response.Redirect("AdminHomePage.aspx");
            else if (Session["type"].Equals("2"))
                Response.Redirect("StudentHomePage.aspx");
            message.Visible = false;
            errorMessage.Visible = false;
        }
        
        protected void define_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            try
            {
                int _ID = (int)Session["user"];
                int _courseID = Int16.Parse(courseID.Text);
                int _assignmentNumber = Int16.Parse(assignmentNumber.Text);
                string _assignmentType = assignmentType.SelectedValue;
                int _fullGrade = Int16.Parse(fullGrade.Text);
                decimal _weight = Decimal.Parse(weight.Text);
                string _content = content.Text;
                string _deadline = deadline.Text;

                SqlCommand DefineAssignmentOfCourseOfCertianType = new SqlCommand("DefineAssignmentOfCourseOfCertianType", conn);
                DefineAssignmentOfCourseOfCertianType.CommandType = CommandType.StoredProcedure;

                DefineAssignmentOfCourseOfCertianType.Parameters.Add(new SqlParameter("@instId", _ID));
                DefineAssignmentOfCourseOfCertianType.Parameters.Add(new SqlParameter("@cid", _courseID));
                DefineAssignmentOfCourseOfCertianType.Parameters.Add(new SqlParameter("@number", _assignmentNumber));
                DefineAssignmentOfCourseOfCertianType.Parameters.Add(new SqlParameter("@fullGrade", _fullGrade));
                DefineAssignmentOfCourseOfCertianType.Parameters.Add(new SqlParameter("@weight", _weight));
                DefineAssignmentOfCourseOfCertianType.Parameters.Add(new SqlParameter("@deadline", _deadline));
                DefineAssignmentOfCourseOfCertianType.Parameters.Add(new SqlParameter("@type", _assignmentType));
                DefineAssignmentOfCourseOfCertianType.Parameters.Add(new SqlParameter("@content", _content));

                conn.Open();
                DefineAssignmentOfCourseOfCertianType.ExecuteNonQuery();
                conn.Close();
                message.Visible = true;
            }
            catch (System.Data.SqlClient.SqlException)
            {
                errorMessage.Visible = true;
            }
            catch (System.FormatException)
            {
                errorMessage.Visible = true;
            }
            catch (System.OverflowException)
            {
                errorMessage.Visible = true;
            }

        }

        protected void assignmentType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}