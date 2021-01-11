using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class Promocodes : Page
    {
        public static string connectionStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
        public static SqlConnection connection = new SqlConnection(connectionStr);
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Int16.Parse(Session["user"].ToString());

            TableHeaderRow headerRow = new TableHeaderRow();
            
            TableHeaderCell codeCell = new TableHeaderCell();
            TableHeaderCell issueDateCell = new TableHeaderCell();
            TableHeaderCell expiryDateCell = new TableHeaderCell();
            TableHeaderCell discountCell = new TableHeaderCell();
            TableHeaderCell adminIDCell = new TableHeaderCell();
            
            codeCell.Text = "Code";
            issueDateCell.Text = "Issue Date";
            expiryDateCell.Text = "Expiry Date";
            discountCell.Text = "Discount";
            adminIDCell.Text = "Admin ID";

            headerRow.Cells.Add(codeCell);
            headerRow.Cells.Add(issueDateCell);
            headerRow.Cells.Add(expiryDateCell);
            headerRow.Cells.Add(discountCell);
            headerRow.Cells.Add(adminIDCell);

            promocodes.Rows.Add(headerRow);
            
            SqlCommand viewPromocodes = new SqlCommand("viewPromocode", connection);
            viewPromocodes.CommandType = CommandType.StoredProcedure;
            viewPromocodes.Parameters.Add(new SqlParameter("@sid", id));   
            
            setPromocodesTable(viewPromocodes);
            

        }

        private void setPromocodesTable(SqlCommand c)
        {
            connection.Open();
            SqlDataReader dataReader = c.ExecuteReader();

            while (dataReader.Read())
            {
                TableRow row = new TableRow();

                TableCell codeCell = new TableCell();
                TableCell issueDateCell = new TableCell();
                TableCell expiryDateCell = new TableCell();
                TableCell discountCell = new TableCell();
                TableCell adminIDCell = new TableCell();

                codeCell.Text = dataReader["code"].ToString();
                issueDateCell.Text = dataReader["isuueDate"].ToString();
                expiryDateCell.Text = dataReader["expiryDate"].ToString();
                discountCell.Text = dataReader["discount"].ToString();
                adminIDCell.Text = dataReader["adminId"].ToString();

                row.Cells.Add(codeCell);
                row.Cells.Add(issueDateCell);
                row.Cells.Add(expiryDateCell);
                row.Cells.Add(discountCell);
                row.Cells.Add(adminIDCell);

                promocodes.Rows.Add(row);
            }
            connection.Close();

        }
        
    }
}