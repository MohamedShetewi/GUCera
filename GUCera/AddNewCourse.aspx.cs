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
    public partial class AddNewCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
                Response.Redirect("Login.aspx");
            else if (Session["type"].Equals("1"))
                Response.Redirect("AdminHomePage.aspx");
            else if (Session["type"].Equals("2"))
                Response.Redirect("StudentHomePage.aspx");
            message.Visible = false;
            errorMessage.Visible = false;
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            try
            {
                int _creditHours = Int16.Parse(creditHours.Text);
                decimal _price = Decimal.Parse(price.Text);
                string _courseName = courseName.Text;


                SqlCommand InstAddCourse = new SqlCommand("InstAddCourse", conn);
                InstAddCourse.CommandType = CommandType.StoredProcedure;

                InstAddCourse.Parameters.Add(new SqlParameter("@creditHours", _creditHours));
                InstAddCourse.Parameters.Add(new SqlParameter("@name", _courseName));
                InstAddCourse.Parameters.Add(new SqlParameter("@price", _price));
                InstAddCourse.Parameters.Add(new SqlParameter("@instructorId", Session["user"]));

                
                conn.Open();
                InstAddCourse.ExecuteNonQuery();
                conn.Close();
                message.Visible = true;
            }
            catch (System.Data.SqlClient.SqlException)
            {
                errorMessage.Visible = true;
            }
            catch (System.FormatException)
            {
                errorMessage.Visible = true;
            }
            catch (System.OverflowException)
            {
                errorMessage.Visible = true;
            }
        }
    }
}