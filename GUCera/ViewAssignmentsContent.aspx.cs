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
    public partial class ViewAssignmentsContent : System.Web.UI.Page
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
                String _ID = ((int)Session["user"])+"";

                SqlCommand viewAssign =new SqlCommand("viewAssign", conn);
                viewAssign.CommandType = CommandType.StoredProcedure;

                viewAssign.Parameters.Add(new SqlParameter("@courseID", _courseID));
                viewAssign.Parameters.Add(new SqlParameter("@Sid", _ID));
                

                conn.Open();
                SqlDataReader reader = viewAssign.ExecuteReader(CommandBehavior.CloseConnection);

                tableTitle.Visible = true;
                TableHeaderRow headerRow = new TableHeaderRow();

                TableHeaderCell col1 = new TableHeaderCell();
                col1.Text = "Course ID";
                col1.Scope = TableHeaderScope.Column;
               
                TableHeaderCell col2 = new TableHeaderCell();
                col2.Text = "Assignment Number";
                col2.Scope = TableHeaderScope.Column;
                
                TableHeaderCell col3 = new TableHeaderCell();
                col3.Text = "Assignment Type";
                col3.Scope = TableHeaderScope.Column;
                
                TableHeaderCell col4 = new TableHeaderCell();
                col4.Text = "Full grade";
                col4.Scope = TableHeaderScope.Column;
                
                TableHeaderCell col5 = new TableHeaderCell();
                col5.Text = "Weight";
                col5.Scope = TableHeaderScope.Column;
                
                TableHeaderCell col6 = new TableHeaderCell();
                col6.Text = "Deadline";
                col6.Scope = TableHeaderScope.Column;
                
                TableHeaderCell col7 = new TableHeaderCell();
                col7.Text = "Content";
                col7.Scope = TableHeaderScope.Column;

                headerRow.Cells.Add(col1);
                headerRow.Cells.Add(col2);
                headerRow.Cells.Add(col3);
                headerRow.Cells.Add(col4);
                headerRow.Cells.Add(col5);
                headerRow.Cells.Add(col6);
                headerRow.Cells.Add(col7);

                table.Rows.Add(headerRow);

                while (reader.Read())
                {
                    
                    string courseId = reader["cid"].ToString();
                    string assignmentNumber = reader["Number"].ToString();
                    string assignmentType = reader["type"].ToString();
                    string fullgrade = reader["fullGrade"].ToString();
                    string weight = reader["weight"].ToString();
                    string deadline = reader["deadline"].ToString();
                    string content = reader["content"].ToString();


                    TableRow row = new TableRow();

                    TableCell courseIDCell = new TableCell();
                    courseIDCell.Text = courseId;
                    row.Cells.Add(courseIDCell);

                    TableCell assignmentNumberCell = new TableCell();
                    assignmentNumberCell.Text = assignmentNumber;
                    row.Cells.Add(assignmentNumberCell);

                    TableCell assignmentTypeCell = new TableCell();
                    assignmentTypeCell.Text = assignmentType;
                    row.Cells.Add(assignmentTypeCell);

                    TableCell fullgradeCell = new TableCell();
                    fullgradeCell.Text = fullgrade;
                    row.Cells.Add(fullgradeCell);

                    TableCell weightCell = new TableCell();
                    weightCell.Text = weight;
                    row.Cells.Add(weightCell);

                    TableCell deadlineCell = new TableCell();
                    deadlineCell.Text = deadline;
                    row.Cells.Add(deadlineCell);    

                    TableCell contentCell = new TableCell();
                    contentCell.Text = content;
                    row.Cells.Add(contentCell);


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