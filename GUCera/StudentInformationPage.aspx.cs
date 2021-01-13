using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class StudentInformationPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection connection = new SqlConnection(connectionStr);

            int id = (int) Session["User"];

            SqlCommand viewMyProfile = new SqlCommand("viewMyProfile", connection);
            viewMyProfile.CommandType = CommandType.StoredProcedure;
            viewMyProfile.Parameters.Add(new SqlParameter("@id", id));

            connection.Open();
            SqlDataReader queryReader = viewMyProfile.ExecuteReader();
            
            while (queryReader.Read())
            {
                IDRow.Cells.Add(addCell(queryReader["id"].ToString()));
                firstNameRow.Cells.Add(addCell(queryReader["firstName"].ToString()));
                lastNameRow.Cells.Add(addCell(queryReader["lastName"].ToString()));
                passwordRow.Cells.Add(addCell(queryReader["password"].ToString()));
                emailRow.Cells.Add(addCell(queryReader["email"].ToString()));
                addressRow.Cells.Add(addCell(queryReader["address"].ToString()));
                gpaRow.Cells.Add(addCell(queryReader["gpa"].ToString()));
                
                string gender = queryReader["gender"].ToString() == "0" ? "Female" : "Male";
                genderRow.Cells.Add(addCell(gender));
            }
            connection.Close();

        }
        
        
        private TableCell addCell( string value)
        {
            TableCell cell = new TableCell();
            cell.Text = value;
            return cell;
        }

    }
}