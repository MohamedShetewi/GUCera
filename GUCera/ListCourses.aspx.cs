using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class ListCourses : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
                Response.Redirect("Login.aspx");
            else if (Session["type"].Equals("0"))
                Response.Redirect("InstructorHomePage.aspx");
            else if (Session["type"].Equals("2"))
                Response.Redirect("StudentHomePage.aspx");
            else
            {
                string connectionStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection connection = new SqlConnection(connectionStr);

                SqlCommand adminViewAllCourses = new SqlCommand("AdminViewAllCourses", connection);
                adminViewAllCourses.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader reader = adminViewAllCourses.ExecuteReader();

                TableHeaderRow headerRow = new TableHeaderRow();
                
                TableHeaderCell col1 = new TableHeaderCell();
                col1.Text = "Name";
                col1.Scope = TableHeaderScope.Column;
                TableHeaderCell col2 = new TableHeaderCell();
                col2.Text = "Credit Hours";
                col2.Scope = TableHeaderScope.Column;
                TableHeaderCell col3 = new TableHeaderCell();
                col3.Text = "Price";
                col3.Scope = TableHeaderScope.Column;
                TableHeaderCell col4 = new TableHeaderCell();
                col4.Text = "Content";
                col4.Scope = TableHeaderScope.Column;
                TableHeaderCell col5 = new TableHeaderCell();
                col5.Text = "Accepted";
                col5.Scope = TableHeaderScope.Column;

                headerRow.Cells.Add(col1);
                headerRow.Cells.Add(col2);
                headerRow.Cells.Add(col3);
                headerRow.Cells.Add(col4);
                headerRow.Cells.Add(col5);

                courses.Rows.Add(headerRow);
                
                while (reader.Read())
                {
                    TableRow row = new TableRow();
                    
                    TableCell name = new TableCell();
                    TableCell creditHours = new TableCell();
                    TableCell price = new TableCell();
                    TableCell content = new TableCell();
                    TableCell accepted = new TableCell();

                    name.Text = reader["name"].ToString();
                    creditHours.Text = reader["creditHours"].ToString();
                    price.Text = reader["price"].ToString();
                    content.Text = reader["content"].ToString();
                    accepted.Text = reader["accepted"].ToString();

                    row.Cells.Add(name);
                    row.Cells.Add(creditHours);
                    row.Cells.Add(price);
                    row.Cells.Add(content);
                    row.Cells.Add(accepted);

                    courses.Rows.Add(row);
                }
                connection.Close();
            }
        }
    }
}