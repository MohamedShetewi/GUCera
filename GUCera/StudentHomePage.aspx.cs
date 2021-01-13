using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class StudentHomePage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        private TableCell addCell( string value)
        {
            TableCell cell = new TableCell();
            cell.Text = value;
            return cell;
        }
        
        protected void availableCourses_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("AvailableCourses.aspx");
        }
        
        protected void addCreditCard_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("AddCreditCard.aspx");
        }

        protected void viewPromoCodes_OnClick(object sender, EventArgs e)
        {
          Response.Redirect("Promocodes.aspx");
        }
    }
}