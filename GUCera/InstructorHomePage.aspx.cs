using System;
using System.Web.UI;

namespace GUCera
{
    public partial class InstructorHomePage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
                Response.Redirect("Login.aspx");
            else if (Session["type"].Equals("1"))
                Response.Redirect("AdminHomePage.aspx");
            else if (Session["type"].Equals("2"))
                Response.Redirect("StudentHomePage.aspx");
        }

        protected void btn1_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("AddNewCourse.aspx");
        }

        protected void btn2_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("DefineAssignments.aspx");
        }

        protected void btn3_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("ViewAssignments.aspx");
        }

        protected void btn4_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("GradeAssignments.aspx");
        }

        protected void btn5_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("ViewFeedback.aspx");
        }

        protected void btn6_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("IssueCertificate.aspx");
        }
    }
}