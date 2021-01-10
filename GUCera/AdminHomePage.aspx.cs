using System;
using System.Web.UI;

namespace GUCera
{
    public partial class AdminHomePage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
                Response.Redirect("Login.aspx");
            else if (Session["type"].Equals("0"))
                Response.Redirect("InstructorHomePage.aspx");
            else if (Session["type"].Equals("2"))
                Response.Redirect("StudentHomePage.aspx");
        }

        protected void btn1_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("ListCourses.aspx");
        }

        protected void btn2_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("ListNonAcceptedCourses.aspx");
        }

        protected void btn3_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("CreatePromocode.aspx");
        }

        protected void btn4_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("IssuePromocode.aspx");
        }

        protected void btn5_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("AcceptCourse.aspx");
        }
    }
}