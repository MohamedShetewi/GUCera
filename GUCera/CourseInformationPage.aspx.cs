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
        public static string connectionStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
        public static SqlConnection connection = new SqlConnection(connectionStr);

        protected void Page_Load(object sender, EventArgs e)
        {
            courseID = Int16.Parse(Request.QueryString["courseID"]);

            setCourseInformation();

            instructorList.Items.Clear();

            connection = new SqlConnection(connectionStr);
            string queryString = "select insid from InstructorTeachCourse where cid = @courseID";
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@courseID", courseID);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                setInstructorName(Int16.Parse(reader["insid"].ToString()));

            connection.Close();
        }

        private void setCourseInformation()
        {
            SqlCommand courseInformation = new SqlCommand("courseInformation", connection);
            courseInformation.CommandType = CommandType.StoredProcedure;
            courseInformation.Parameters.Add("@id", courseID);

            connection.Open();
            SqlDataReader queryReader = courseInformation.ExecuteReader();
            while (queryReader.Read())
            {
                nameLabel.Text = queryReader["name"].ToString();
                creditHoursLabel.Text = queryReader["creditHours"].ToString();
                priceLabel.Text = queryReader["price"].ToString();
                courseDesLabel.Text = queryReader["courseDescription"].ToString();
            }

            connection.Close();
        }

        private void setInstructorName(int id)
        {
            string connectionStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection connection2 = new SqlConnection(connectionStr);
            string queryString =
                "select firstName, lastName from InstructorTeachCourse inner join Users on insid = id where insid = @instID";
            SqlCommand getInstructor = new SqlCommand(queryString, connection2);
            getInstructor.Parameters.AddWithValue("@instID", id);

            ListItem instItem = new ListItem();
            instItem.Value = id.ToString();

            connection2.Open();
            SqlDataReader sqlDataReader = getInstructor.ExecuteReader();
            while (sqlDataReader.Read())
            {
                instItem.Text = sqlDataReader["firstName"].ToString() + " " +
                                sqlDataReader["lastName"].ToString();
            }

            connection2.Close();
            instructorList.Items.Add(instItem);
        }

        protected void enroll_OnClick(object sender, EventArgs e)
        {
            if (instructorList.SelectedValue == "-1")
            {
                Response.Write("Please choose Instructor");
            }
            else
            {
                string connectionStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection connection = new SqlConnection(connectionStr);
                int studentID = Int16.Parse(Session["user"].ToString());
                int instructorID = Int16.Parse(instructorList.SelectedValue);

                Response.Write(studentID);
                Response.Write(instructorID);

                //@sid INT, @cid INT, @instr int
                SqlCommand enroll = new SqlCommand("enrollInCourse", connection);
                enroll.CommandType = CommandType.StoredProcedure;

                enroll.Parameters.Add(new SqlParameter("@sid", studentID));
                enroll.Parameters.Add(new SqlParameter("@instr", instructorID));
                enroll.Parameters.Add(new SqlParameter("@cid", courseID));

                connection.Open();
                enroll.ExecuteNonQuery();
                connection.Close();

                Response.Write("Enrolled Successfully!!");
            }
        }
    }
}