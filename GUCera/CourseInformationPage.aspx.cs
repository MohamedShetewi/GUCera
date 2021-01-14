using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class Course : Page
    {
        public static int courseID;
        public static int instructorID;
        public static string connectionStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
        public static SqlConnection connection = new SqlConnection(connectionStr);

        protected void Page_Load(object sender, EventArgs e)
        {
            courseID = Int16.Parse(Request.QueryString["courseID"]);
            setCourseInformation();
            errorMessage.Visible = false;
            successMessage.Visible = false;

        }

        private void setCourseInformation()
        {
            SqlCommand courseInformation = new SqlCommand("courseInformation", connection);
            courseInformation.CommandType = CommandType.StoredProcedure;
            courseInformation.Parameters.Add(new SqlParameter("@id", courseID));

            connection.Open();
            SqlDataReader queryReader = courseInformation.ExecuteReader();

            while (queryReader.Read())
            {
                nameRow.Cells.Add(addCell(queryReader["name"].ToString()));
                creditHoursRow.Cells.Add(addCell(queryReader["creditHours"].ToString()));
                priceRow.Cells.Add(addCell(queryReader["price"].ToString()));
                descriptionRow.Cells.Add(addCell(queryReader["courseDescription"].ToString()));
                instructorCell.Cells.Add(addCell(queryReader["firstName"].ToString() + " " +
                                                 queryReader["lastName"].ToString()));
            }
            connection.Close();
            
        }

        protected void enroll_OnClick(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionStr);
                string queryString = "select insid from InstructorTeachCourse where cid = @courseID";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@courseID", courseID);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                    instructorID = (Int16.Parse(reader["insid"].ToString()));

                connection.Close();

                //@sid INT, @cid INT, @instr int

                int studentID = Int16.Parse(Session["user"].ToString());

                SqlCommand enroll = new SqlCommand("enrollInCourse", connection);
                enroll.CommandType = CommandType.StoredProcedure;

                enroll.Parameters.Add(new SqlParameter("@sid", studentID));
                enroll.Parameters.Add(new SqlParameter("@instr", instructorID));
                enroll.Parameters.Add(new SqlParameter("@cid", courseID));

                connection.Open();
                enroll.ExecuteNonQuery();
                connection.Close();
                successMessage.Visible = true;
            }
            catch(SqlException)
            {
                connection.Close();
                errorMessage.Visible = true;
            }
        }


        private TableCell addCell(string value)
        {
            TableCell cell = new TableCell();
            cell.Text = value;
            return cell;
        }
    }
}