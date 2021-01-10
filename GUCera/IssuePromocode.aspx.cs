using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI;

namespace GUCera
{
    public partial class IssuePromocode : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
                Response.Redirect("Login.aspx");
            else if (Session["type"].Equals("0"))
                Response.Redirect("InstructorHomePage.aspx");
            else if (Session["type"].Equals("2"))
                Response.Redirect("StudentHomePage.aspx");
            message.Visible = false;
            errorMessage.Visible = false;
        }

        protected void issueBtn_OnClick(object sender, EventArgs e)
        {
            try
            {
                string connectionString = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand adminIssuePromocodeToStudent = new SqlCommand("AdminIssuePromocodeToStudent", connection);
                adminIssuePromocodeToStudent.CommandType = CommandType.StoredProcedure;

                string _code = code.Text;
                int _studentId = Int16.Parse(studentId.Text);

                adminIssuePromocodeToStudent.Parameters.Add(new SqlParameter("@sid", _studentId));
                adminIssuePromocodeToStudent.Parameters.Add(new SqlParameter("@pid", _code));
                
                connection.Open();
                adminIssuePromocodeToStudent.ExecuteNonQuery();
                connection.Close();

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
    }
}