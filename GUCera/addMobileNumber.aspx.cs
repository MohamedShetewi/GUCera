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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
                Response.Redirect("Login.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            int _ID = (int) Session["user"];
            string _mobileNumber = mobilenumber.Text;

            SqlCommand addMobile = new SqlCommand("addMobile", conn);
            addMobile.CommandType = CommandType.StoredProcedure;

            addMobile.Parameters.Add(new SqlParameter("@ID", _ID));
            addMobile.Parameters.Add(new SqlParameter("@mobile_number", _mobileNumber));

            try
            {
                conn.Open();
                addMobile.ExecuteNonQuery();
                conn.Close();
            }
            catch   (System.Data.SqlClient.SqlException)
            {
                Response.Write("Mobile Number already added or invalid mobile number.");
            }
            
        }
    }
}