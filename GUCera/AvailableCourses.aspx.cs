using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class AvailableCourses : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection connection = new SqlConnection(connectionStr);

            
            TableHeaderRow headerRow= new TableHeaderRow();
            
            TableHeaderCell courseNameCol = new TableHeaderCell();
            courseNameCol.Text = "Name";
            TableHeaderCell viewCol = new TableHeaderCell();
            
            
            headerRow.Cells.Add(courseNameCol);
            headerRow.Cells.Add(viewCol);
            availableCourses.Rows.Add(headerRow);
            
            SqlCommand listCourses = new SqlCommand("availableCourses",connection);
            listCourses.CommandType = CommandType.StoredProcedure;
            connection.Open();
            SqlDataReader queryReader = listCourses.ExecuteReader();
            
            
            while (queryReader.Read())
            {
                TableRow row = new TableRow();

                TableCell courseNameCell = new TableCell();
                string courseName = queryReader["name"].ToString();
                courseNameCell.Text = courseName;

                TableCell viewCourseCell = new TableCell();
                Button view = new Button();
                
                int courseID = getCourseId(courseName);
                view.Text = "View Course";
                view.ID = courseID.ToString();
                view.Attributes.Add("runat", "server");
                view.CssClass = "btn btn-primary";
                view.Click += new EventHandler(view_OnClick);
                
                viewCourseCell.Controls.Add(view);

                row.Cells.Add(courseNameCell);
                row.Cells.Add(viewCourseCell);

                availableCourses.Rows.Add(row);
            }

        }

        private static int getCourseId(string courseName)
        {
            string connectionStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection connection = new SqlConnection(connectionStr);
            string queryString = "select id from Course where name = @cname";

            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@cname", courseName);
            connection.Open();

            int courseID = 0;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                courseID = Int16.Parse(reader["id"].ToString());
            }
            connection.Close();
            
            return courseID;
        }

        protected void view_OnClick(object sender, EventArgs e)
        {
            string courseID = ((Button) sender).ID;
            Response.Redirect(String.Format("CourseInformationPage.aspx?courseID={0}",courseID));
        }
    }
}