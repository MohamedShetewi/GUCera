<%@ Page Language="C#" CodeBehind="Course.aspx.cs" Inherits="GUCera.Course" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server" xmlns="http://www.w3.org/1999/html">

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet"/>
    <script src="Scripts/bootstrap.bundle.js"></script>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Course Information</title>
    <style type="text/css">
                  body{
                      background-color: #29BE75;
                  }
                  .courses{
                     width: 70%;
                     background-color: rgba(254, 252, 251, 0.7);
                     text-align: center;
                  } .vertical-center {
                     min-height:50%;  /* Fallback for browsers do NOT support vh unit */
                     min-height: 60vh; /* These two lines are counted as one :-)       */                       
                     display: flex;
                     align-items: center;        
                  }
                  .courses{
                    border-radius: 20px;      
                    background-color: rgba(254, 252, 251, 0.7);
                  }
               		     
              </style>
</head>
<body>

<nav class="navbar navbar-expand-lg navbar-dark" style="background-color: #261447">
    <div class="container-fluid">
        <span class="navbar-brand ms-2">GUCera</span>
        <div>
            <ul class="navbar-nav d-flex justify-content-end">
                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" href="#" id="navbarDropdownMenuLink" role="button" data-bs-toggle="dropdown" aria-expanded="False">
                        User ID: <% = Session["user"] %>
                    </a>
                    <ul class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                        <li>
                            <a class="dropdown-item" href="StudentInformationPage.aspx">Personal Information</a>
                        </li>
                        <li>
                            <a class="dropdown-item" href="AddMobileNumber.aspx">Add Mobile Number</a>
                        </li>

                    </ul>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="StudentHomePage.aspx">
                        Student Dashboard
                    </a>
                </li>
            </ul>
        </div>
    </div>
</nav>
<form id="HtmlForm" runat="server">
    <div class="container">

        <h1 style="color: white" class="m-5 d-flex justify-content-center">Information</h1>
        <div class="d-flex mt-5 justify-content-center">
            <asp:table class="table table-user-information" CellPadding="10" CssClass="courses table-striped" ID="information" runat="server">

                <asp:TableRow runat="server" ID="nameRow">
                    <asp:TableCell>
                        <strong>Course Name</strong>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server" ID="creditHoursRow">
                    <asp:TableCell>
                        <strong>Credit Hours</strong>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow runat="server" ID="priceRow">
                    <asp:TableCell>
                        <strong>Price</strong>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow runat="server" ID="descriptionRow">
                    <asp:TableCell>
                        <strong>Course Description</strong>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow runat="server" ID="instructorCell">
                    <asp:TableCell>
                        <strong>Instructor</strong>
                    </asp:TableCell>
                </asp:TableRow>

            </asp:table>
        </div>

    </div>
    <br/>
    <div class="row justify-content-center">
        <asp:Button runat="server" Text="Enroll" OnClick="enroll_OnClick" CssClass="btn btn-primary" style="max-width: fit-content;"/>
    </div>

    <br/>
    <div class="d-flex justify-content-center" Visible="False" runat="server" ID="successMessage">
        <div class="alert alert-success" role="alert" style="max-width: fit-content">
            Enrolled Successfully!
        </div>
    </div>
    <div class="d-flex justify-content-center" Visible="False" runat="server" ID="errorMessage">
        <div class="alert alert-danger" role="alert" style="max-width: fit-content">
            Cannot Enroll!
        </div>
    </div>
</form>
</body>
</html>