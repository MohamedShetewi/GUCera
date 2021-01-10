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
    public partial class ViewFeedback : System.Web.UI.Page
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

        protected void viewButton_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            try
            {
                int _ID = (int)Session["user"];
                int _courseID = Int16.Parse(courseID.Text);


                SqlCommand ViewFeedbacksAddedByStudentsOnMyCourse = new SqlCommand("ViewFeedbacksAddedByStudentsOnMyCourse", conn);
                ViewFeedbacksAddedByStudentsOnMyCourse.CommandType = CommandType.StoredProcedure;

                ViewFeedbacksAddedByStudentsOnMyCourse.Parameters.Add(new SqlParameter("@instrId", _ID));
                ViewFeedbacksAddedByStudentsOnMyCourse.Parameters.Add(new SqlParameter("@cid", _courseID));


                conn.Open();
                SqlDataReader reader = ViewFeedbacksAddedByStudentsOnMyCourse.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    int _feedbackNumber = reader.GetInt32(reader.GetOrdinal("number"));
                    string _comment = reader.GetString(reader.GetOrdinal("comment"));
                    int _numberOfLikes = reader.GetInt32(reader.GetOrdinal("numberOfLikes"));

                    TableRow row = new TableRow();

                    TableCell _feedbackNumberCell = new TableCell();
                    _feedbackNumberCell.Text = _feedbackNumber.ToString();
                    row.Controls.Add(_feedbackNumberCell);

                    TableCell _commentCell = new TableCell();
                    _commentCell.Text = _comment.ToString();
                    row.Controls.Add(_commentCell);

                    TableCell _numberOfLikesCell = new TableCell();
                    _numberOfLikesCell.Text = _numberOfLikes.ToString();
                    row.Controls.Add(_numberOfLikesCell);

                    table.Rows.Add(row);


                }
            }
            catch (System.FormatException)
            {
                Response.Write("Please enter a valid course ID.");
            }
            catch (System.OverflowException)
            {
                Response.Write("Please enter a valid course ID.");
            }


        }
    }
}