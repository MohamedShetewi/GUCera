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
        }

        protected void viewButton_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            try {
                int _courseID = Int16.Parse(courseID.Text);
                int _ID = (int)Session["user"];

                SqlCommand InstructorViewAssignmentsStudents = new SqlCommand("InstructorViewAssignmentsStudents", conn);
                InstructorViewAssignmentsStudents.CommandType = CommandType.StoredProcedure;

                InstructorViewAssignmentsStudents.Parameters.Add(new SqlParameter("@instrId", _ID));
                InstructorViewAssignmentsStudents.Parameters.Add(new SqlParameter("@cid", _courseID));

                conn.Open();
                SqlDataReader reader = InstructorViewAssignmentsStudents.ExecuteReader(CommandBehavior.CloseConnection);


                while (reader.Read())
                {
                    int studentID = reader.GetInt32(reader.GetOrdinal("sid"));
                    int courseID = reader.GetInt32(reader.GetOrdinal("cid"));
                    int assignmentNumber = reader.GetInt32(reader.GetOrdinal("assignmentNumber"));
                    string assignmentType = reader.GetString(reader.GetOrdinal("assignmenttype"));
                    decimal grade = reader.GetDecimal(reader.GetOrdinal("grade"));

                    TableRow row = new TableRow();

                    TableCell studentIDCell = new TableCell();
                    studentIDCell.Text = studentID.ToString();
                    row.Controls.Add(studentIDCell);

                    TableCell courseIDCell = new TableCell();
                    courseIDCell.Text = courseID.ToString();
                    row.Controls.Add(courseIDCell);

                    TableCell assignmentNumberCell = new TableCell();
                    assignmentNumberCell.Text = assignmentNumber.ToString();
                    row.Controls.Add(assignmentNumberCell);

                    TableCell assignmentTypeCell = new TableCell();
                    assignmentTypeCell.Text = assignmentType;
                    row.Controls.Add(assignmentTypeCell);

                    TableCell gradeCell = new TableCell();
                    gradeCell.Text = grade.ToString();
                    row.Controls.Add(gradeCell);

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