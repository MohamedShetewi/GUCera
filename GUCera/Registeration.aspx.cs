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
    public partial class Registeration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void register_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            string _firstName = firstName.Text;
            string _lastName = lastName.Text;
            string _password = password.Text;
            string _email = email.Text;
            string _address = address.Text;
            bool _gender = gender.SelectedValue.Equals("1");
            bool _type = type.SelectedValue.Equals("0"); //instructor

            if (_type)
            {
                SqlCommand instructorRegister = new SqlCommand("InstructorRegister", conn);
                instructorRegister.CommandType = CommandType.StoredProcedure;

                instructorRegister.Parameters.Add(new SqlParameter("@first_name", _firstName));
                instructorRegister.Parameters.Add(new SqlParameter("@last_name", _lastName));
                instructorRegister.Parameters.Add(new SqlParameter("@password", _password));
                instructorRegister.Parameters.Add(new SqlParameter("@email", _email));
                instructorRegister.Parameters.Add(new SqlParameter("@gender", _gender));
                instructorRegister.Parameters.Add(new SqlParameter("@address", _address));

                try
                {
                    conn.Open();
                    instructorRegister.ExecuteNonQuery();
                    conn.Close();
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    Response.Write("Please stick to length of maximum 10 letters.");
                }
            }
            else
            {
                SqlCommand studentRegister = new SqlCommand("studentRegister", conn);
                studentRegister.CommandType = CommandType.StoredProcedure;

                studentRegister.Parameters.Add(new SqlParameter("@first_name", _firstName));
                studentRegister.Parameters.Add(new SqlParameter("@last_name", _lastName));
                studentRegister.Parameters.Add(new SqlParameter("@password", _password));
                studentRegister.Parameters.Add(new SqlParameter("@email", _email));
                studentRegister.Parameters.Add(new SqlParameter("@gender", _gender));
                studentRegister.Parameters.Add(new SqlParameter("@address", _address));

                try
                {
                    conn.Open();
                    studentRegister.ExecuteNonQuery();
                    conn.Close();
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    Response.Write("Please stick to length of maximum 10 letters.");
                }
            }
            

         
        }
    }
}