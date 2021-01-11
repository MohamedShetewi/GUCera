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
            errorMessage.Visible = false;
            tableTitle.Visible = false;
        }

        protected void viewButton_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            try
            {
                int _ID = (int) Session["user"];
                int _courseID = Int16.Parse(courseID.Text);


                SqlCommand ViewFeedbacksAddedByStudentsOnMyCourse =
                    new SqlCommand("ViewFeedbacksAddedByStudentsOnMyCourse", conn);
                ViewFeedbacksAddedByStudentsOnMyCourse.CommandType = CommandType.StoredProcedure;

                ViewFeedbacksAddedByStudentsOnMyCourse.Parameters.Add(new SqlParameter("@instrId", _ID));
                ViewFeedbacksAddedByStudentsOnMyCourse.Parameters.Add(new SqlParameter("@cid", _courseID));


                conn.Open();
                SqlDataReader reader =
                    ViewFeedbacksAddedByStudentsOnMyCourse.ExecuteReader(CommandBehavior.CloseConnection);
                
                tableTitle.Visible = true;
                TableHeaderRow headerRow = new TableHeaderRow();

                TableHeaderCell col1 = new TableHeaderCell();
                col1.Text = "Number";
                col1.Scope = TableHeaderScope.Column;
                TableHeaderCell col2 = new TableHeaderCell();
                col2.Text = "Comment";
                col2.Scope = TableHeaderScope.Column;
                TableHeaderCell col3 = new TableHeaderCell();
                col3.Text = "Number of Likes";
                col3.Scope = TableHeaderScope.Column;
                
                headerRow.Cells.Add(col1);
                headerRow.Cells.Add(col2);
                headerRow.Cells.Add(col3);

                table.Rows.Add(headerRow);

                while (reader.Read())
                {
                    string _feedbackNumber = reader["number"].ToString();
                    string _comment = reader["comment"].ToString();
                    string _numberOfLikes = reader["numberOfLikes"].ToString();

                    TableRow row = new TableRow();

                    TableCell _feedbackNumberCell = new TableCell();
                    _feedbackNumberCell.Text = _feedbackNumber;
                    row.Cells.Add(_feedbackNumberCell);

                    TableCell _commentCell = new TableCell();
                    _commentCell.Text = _comment.ToString();
                    row.Cells.Add(_commentCell);

                    TableCell _numberOfLikesCell = new TableCell();
                    _numberOfLikesCell.Text = _numberOfLikes.ToString();
                    row.Cells.Add(_numberOfLikesCell);

                    table.Rows.Add(row);
                }
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