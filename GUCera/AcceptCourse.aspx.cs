using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI;

namespace GUCera
{
    public partial class AcceptCourse : Page
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

        protected void acceptBtn_OnClick(object sender, EventArgs e)
        {
            try
            {
                string connectionString = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection connection = new SqlConnection(connectionString);

                SqlCommand adminAcceptRejectCourse = new SqlCommand("AdminAcceptRejectCourse", connection);
                adminAcceptRejectCourse.CommandType = CommandType.StoredProcedure;

                int _cid = Int16.Parse(courseId.Text);
                adminAcceptRejectCourse.Parameters.Add(new SqlParameter("@adminid",
                    Int16.Parse(Session["user"].ToString())));
                adminAcceptRejectCourse.Parameters.Add(new SqlParameter("@courseId", _cid));

                connection.Open();
                adminAcceptRejectCourse.ExecuteNonQuery();
                connection.Close();

                message.Visible = true;
            }
            catch (System.FormatException)
            {
                errorMessage.Visible = true;
            }
            catch (System.OverflowException)
            {
                errorMessage.Visible = true;
            }
            catch (System.Data.SqlClient.SqlException)
            {
                errorMessage.Visible = true;
            }
        }
    }
}