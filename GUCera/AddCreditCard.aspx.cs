using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI;

namespace GUCera
{
    public partial class AddCreditCard : Page
    {
        public static string connectionStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            errorMessage.Visible = false;
            successMessage.Visible = false;
        }

        protected void add_OnClick(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection connection = new SqlConnection(connectionStr);
                int id = Int16.Parse(Session["user"].ToString());
                string _creditCard = creditCardNumber.Text;
                string _holderName = holderName.Text;
                DateTime _expiredate = Convert.ToDateTime(expiryDate.Text);
                string _cvv = cvv.Text;

                SqlCommand addCreditCard = new SqlCommand("addCreditCard", connection);
                addCreditCard.CommandType = CommandType.StoredProcedure;

                addCreditCard.Parameters.Add(new SqlParameter("@sid", id));
                addCreditCard.Parameters.Add(new SqlParameter("@number", _creditCard));
                addCreditCard.Parameters.Add(new SqlParameter("@cardHolderName", _holderName));
                addCreditCard.Parameters.Add(new SqlParameter("@expiryDate", _expiredate));
                addCreditCard.Parameters.Add(new SqlParameter("@cvv", _cvv));

                connection.Open();
                addCreditCard.ExecuteNonQuery();
                connection.Close();
                successMessage.Visible = true;
            }
            catch (SqlException)
            {
                errorMessage.Visible = true;
            }
        }
    }
}