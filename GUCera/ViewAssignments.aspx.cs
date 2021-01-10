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
    public partial class ViewAssignments : System.Web.UI.Page
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
                int _courseID = Int16.Parse(courseID.Text);
                int _ID = (int) Session["user"];

                SqlCommand InstructorViewAssignmentsStudents =
                    new SqlCommand("InstructorViewAssignmentsStudents", conn);
                InstructorViewAssignmentsStudents.CommandType = CommandType.StoredProcedure;

                InstructorViewAssignmentsStudents.Parameters.Add(new SqlParameter("@instrId", _ID));
                InstructorViewAssignmentsStudents.Parameters.Add(new SqlParameter("@cid", _courseID));

                conn.Open();
                SqlDataReader reader = InstructorViewAssignmentsStudents.ExecuteReader(CommandBehavior.CloseConnection);

                tableTitle.Visible = true;
                TableHeaderRow headerRow = new TableHeaderRow();

                TableHeaderCell col1 = new TableHeaderCell();
                col1.Text = "Student ID";
                col1.Scope = TableHeaderScope.Column;
                TableHeaderCell col2 = new TableHeaderCell();
                col2.Text = "Course ID";
                col2.Scope = TableHeaderScope.Column;
                TableHeaderCell col3 = new TableHeaderCell();
                col3.Text = "Assignment Number";
                col3.Scope = TableHeaderScope.Column;
                TableHeaderCell col4 = new TableHeaderCell();
                col4.Text = "Assignment Type";
                col4.Scope = TableHeaderScope.Column;
                TableHeaderCell col5 = new TableHeaderCell();
                col5.Text = "Grade";
                col5.Scope = TableHeaderScope.Column;

                headerRow.Cells.Add(col1);
                headerRow.Cells.Add(col2);
                headerRow.Cells.Add(col3);
                headerRow.Cells.Add(col4);
                headerRow.Cells.Add(col5);

                table.Rows.Add(headerRow);

                while (reader.Read())
                {
                    string studentId = reader["sid"].ToString();
                    string courseId = reader["cid"].ToString();
                    string assignmentNumber = reader["assignmentNumber"].ToString();
                    string assignmentType = reader["assignmenttype"].ToString();
                    string grade = reader["grade"].ToString();

                    TableRow row = new TableRow();

                    TableCell studentIDCell = new TableCell();
                    studentIDCell.Text = studentId;
                    row.Cells.Add(studentIDCell);

                    TableCell courseIDCell = new TableCell();
                    courseIDCell.Text = courseId;
                    row.Cells.Add(courseIDCell);

                    TableCell assignmentNumberCell = new TableCell();
                    assignmentNumberCell.Text = assignmentNumber;
                    row.Cells.Add(assignmentNumberCell);

                    TableCell assignmentTypeCell = new TableCell();
                    assignmentTypeCell.Text = assignmentType;
                    row.Cells.Add(assignmentTypeCell);

                    TableCell gradeCell = new TableCell();
                    gradeCell.Text = grade;
                    row.Cells.Add(gradeCell);

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