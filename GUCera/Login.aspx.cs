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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connstr);


            try {
                int _ID = Int16.Parse(id.Text);
                string _password = password.Text;
               
                SqlCommand userLogin = new SqlCommand("userLogin", conn);
                userLogin.CommandType = CommandType.StoredProcedure;

                userLogin.Parameters.Add(new SqlParameter("@id", _ID));
                userLogin.Parameters.Add(new SqlParameter("@password", _password));

                SqlParameter _success = userLogin.Parameters.Add("@success", SqlDbType.Bit);
                SqlParameter _type = userLogin.Parameters.Add("@type", SqlDbType.Int);
                _success.Direction = ParameterDirection.Output;
                _type.Direction = ParameterDirection.Output;


                conn.Open();
                userLogin.ExecuteNonQuery();
                conn.Close();
                
                if (_success.Value.ToString().Equals("True"))
                {
                    Session["user"] = _ID;
                    Session["type"] = _type.Value.ToString();

                    if (_type.Value.ToString().Equals("0")) //instructor
                        Response.Redirect("AddNewCourse.aspx");
                    else if (_type.Value.ToString().Equals("2")) //student
                        Response.Redirect("StudentHomePage.aspx");
                    else                                         //admin
                        Response.Redirect("AdminHomePage.aspx");
                }
                else
                    Response.Write("Wrong id or password");
            }
            catch (System.FormatException)
            {
                Response.Write("Please enter your valid id and password");
            }
            catch (System.OverflowException)
            {
                Response.Write("Please enter your valid id and password");
            }
        }
    }


}