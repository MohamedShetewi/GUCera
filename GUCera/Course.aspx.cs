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
        protected void Page_Load(object sender, EventArgs e)
        {
            int courseID = Int16.Parse(Request.QueryString["courseID"]);
            string connectionStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection connection = new SqlConnection(connectionStr);

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
    }
}