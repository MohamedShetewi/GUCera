using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI;

namespace GUCera
{
    public partial class CreatePromocode : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
                Response.Redirect("Login.aspx");
            else if (Session["type"].Equals("0"))
                Response.Redirect("InstructorHomePage.aspx");
            else if (Session["type"].Equals("2"))
                Response.Redirect("StudentHomePage.aspx");
            message.Visible = false;
            errorMessage.Visible = false;
        }

        protected void createBtn_OnClick(object sender, EventArgs e)
        {
            try
            {
                string connectionString = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand adminCreatePromocode = new SqlCommand("AdminCreatePromocode", connection);
                adminCreatePromocode.CommandType = CommandType.StoredProcedure;

                string _code = code.Text;
                string _expiryDate = expiryDate.Text;
                int _discount = Int16.Parse(discount.Text);

                adminCreatePromocode.Parameters.Add(new SqlParameter("@code", _code));
                adminCreatePromocode.Parameters.Add(new SqlParameter("@expiryDate", _expiryDate));
                adminCreatePromocode.Parameters.Add(new SqlParameter("@discount", _discount));
                adminCreatePromocode.Parameters.Add(new SqlParameter("@isuueDate", DateTime.Today.ToString()));
                adminCreatePromocode.Parameters.Add(new SqlParameter("@adminId",
                    Int16.Parse(Session["user"].ToString())));

                connection.Open();
                adminCreatePromocode.ExecuteNonQuery();
                connection.Close();

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