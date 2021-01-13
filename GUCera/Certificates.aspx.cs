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
    public partial class Certificates : System.Web.UI.Page
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
            tableTitle.Visible = false;
        }
        protected void viewButton_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            try
            {
                int _courseID = Int16.Parse(courseID.Text);
                int _ID = ((int)Session["user"]);

                SqlCommand viewCertificate = new SqlCommand("viewCertificate", conn);
                viewCertificate.CommandType = CommandType.StoredProcedure;

                viewCertificate.Parameters.Add(new SqlParameter("@cid", _courseID));
                viewCertificate.Parameters.Add(new SqlParameter("@sid", _ID));

                conn.Open();
                SqlDataReader reader = viewCertificate.ExecuteReader(CommandBehavior.CloseConnection);

                tableTitle.Visible = true;
                TableHeaderRow headerRow = new TableHeaderRow();

                TableHeaderCell col1 = new TableHeaderCell();
                col1.Text = "Course ID";
                col1.Scope = TableHeaderScope.Column;

                TableHeaderCell col2 = new TableHeaderCell();
                col2.Text = "Issue date";
                col2.Scope = TableHeaderScope.Column;

                headerRow.Cells.Add(col1);
                headerRow.Cells.Add(col2);
                
                table.Rows.Add(headerRow);

                while (reader.Read())
                {

                    string courseId = reader["cid"].ToString();
                    string issueDate = reader["issueDate"].ToString();
                    
                    TableRow row = new TableRow();

                    TableCell courseIDCell = new TableCell();
                    courseIDCell.Text = courseId;
                    row.Cells.Add(courseIDCell);

                    TableCell assignmentNumberCell = new TableCell();
                    assignmentNumberCell.Text = issueDate;
                    row.Cells.Add(assignmentNumberCell);

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