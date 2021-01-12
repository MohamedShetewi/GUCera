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
    public partial class AddMobileNumber : Page
    {
        protected string type;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
                Response.Redirect("Login.aspx");
            else if (Session["type"].ToString().Equals("0"))
                type = "Instructor";
            else if (Session["type"].ToString().Equals("1"))
                type = "Admin";
            else
                type = "Student";
            message.Visible = false;
            errorMessage.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connstr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(connstr);

                int _ID = (int) Session["user"];
                string _mobileNumber = mobilenumber.Text;

                SqlCommand addMobile = new SqlCommand("addMobile", conn);
                addMobile.CommandType = CommandType.StoredProcedure;

                addMobile.Parameters.Add(new SqlParameter("@ID", _ID));
                addMobile.Parameters.Add(new SqlParameter("@mobile_number", _mobileNumber));

                conn.Open();
                addMobile.ExecuteNonQuery();
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