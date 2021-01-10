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
    public partial class IssueCertificate : System.Web.UI.Page
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

        protected void issueButton_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            try
            {
                int _ID = (int)Session["user"];
                int _courseID = Int16.Parse(courseID.Text);
                int _studentID = Int16.Parse(studentID.Text);
                string _issueDate = issueDate.Text;

                SqlCommand InstructorIssueCertificateToStudent = new SqlCommand("InstructorIssueCertificateToStudent", conn);
                InstructorIssueCertificateToStudent.CommandType = CommandType.StoredProcedure;

                InstructorIssueCertificateToStudent.Parameters.Add(new SqlParameter("@insId", _ID));
                InstructorIssueCertificateToStudent.Parameters.Add(new SqlParameter("@cid", _courseID));
                InstructorIssueCertificateToStudent.Parameters.Add(new SqlParameter("@sid", _studentID));
                InstructorIssueCertificateToStudent.Parameters.Add(new SqlParameter("@issueDate", _issueDate));

                conn.Open();
                InstructorIssueCertificateToStudent.ExecuteNonQuery();
                conn.Close();

            }
            catch (System.Data.SqlClient.SqlException)
            {
                Response.Write("Invalid details.");
            }
            catch (System.FormatException)
            {
                Response.Write("Invalid details.");
            }
            catch (System.OverflowException)
            {
                Response.Write("Invalid details.");
            }

        }
    }
}