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
    public partial class AddFeedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
                Response.Redirect("Login.aspx");
            else if (Session["type"].Equals("1"))
                Response.Redirect("AdminHomePage.aspx");
            else if (Session["type"].Equals("0"))
                Response.Redirect("InstructorHomePage.aspx");
            message.Visible = false;
            errorMessage.Visible = false;
        }
        protected void viewButton_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            try
            {
                int _courseID = Int16.Parse(courseID.Text);
                String _comment = comment.Text;
                int _ID = ((int)Session["user"]);

                SqlCommand addFeedback = new SqlCommand("addFeedback", conn);
                addFeedback .CommandType = CommandType.StoredProcedure;

                addFeedback.Parameters.Add(new SqlParameter("@cid", _courseID));
                addFeedback.Parameters.Add(new SqlParameter("@comment", _comment));
                addFeedback.Parameters.Add(new SqlParameter("@sid", _ID));

                conn.Open();
                addFeedback.ExecuteNonQuery();
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