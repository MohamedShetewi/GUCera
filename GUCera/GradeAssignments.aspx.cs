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
    public partial class GradeAssignments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
                Response.Redirect("Login.aspx");
            else if (Session["type"].Equals("1"))
                Response.Redirect("AdminHomePage.aspx");
            else if (Session["type"].Equals("2"))
                Response.Redirect("StudentHomePage.aspx");
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            try {
                int _ID = (int)Session["user"];
                int _studentID = Int16.Parse(studentID.Text);
                int _courseID = Int16.Parse(courseID.Text);
                int _assignmentNumber = Int16.Parse(assignmentNumber.Text);
                string _assignmentType = assignmentType.SelectedValue;
                decimal _grade = Decimal.Parse(grade.Text);

                SqlCommand InstructorgradeAssignmentOfAStudent = new SqlCommand("InstructorgradeAssignmentOfAStudent", conn);
                InstructorgradeAssignmentOfAStudent.CommandType = CommandType.StoredProcedure;


                InstructorgradeAssignmentOfAStudent.Parameters.Add(new SqlParameter("@instrId", _ID));
                InstructorgradeAssignmentOfAStudent.Parameters.Add(new SqlParameter("@sid", _studentID));
                InstructorgradeAssignmentOfAStudent.Parameters.Add(new SqlParameter("@cid", _courseID));
                InstructorgradeAssignmentOfAStudent.Parameters.Add(new SqlParameter("@assignmentNumber", _assignmentNumber));
                InstructorgradeAssignmentOfAStudent.Parameters.Add(new SqlParameter("@type", _assignmentType));
                InstructorgradeAssignmentOfAStudent.Parameters.Add(new SqlParameter("@grade", _grade));

                conn.Open();
                InstructorgradeAssignmentOfAStudent.ExecuteNonQuery();
                conn.Close();

            }
            catch (System.FormatException)
            {
                Response.Write("Please enter valid details.");
            }
            catch (System.OverflowException)
            {
                Response.Write("Please enter valid details.");
            }
        }
    }
}