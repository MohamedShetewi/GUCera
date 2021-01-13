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
    public partial class SubmitAssignment : System.Web.UI.Page
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
            message.Visible = false;
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
                int _ID = ((int)Session["user"]);

                SqlCommand submitAssign = new SqlCommand("submitAssign", conn);
                submitAssign.CommandType = CommandType.StoredProcedure;

                submitAssign.Parameters.Add(new SqlParameter("@cid", _courseID));
                submitAssign.Parameters.Add(new SqlParameter("@assignType", _assignmentType));
                submitAssign.Parameters.Add(new SqlParameter("@assignnumber", _assignmentNum));
                submitAssign.Parameters.Add(new SqlParameter("@Sid", _ID));

                conn.Open();
                submitAssign.ExecuteNonQuery();
                conn.Close();
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