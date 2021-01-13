<%@ Page Language="C#" CodeBehind="StudentInformationPage.aspx.cs" Inherits="GUCera.StudentInformationPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet"/>
    <script src="Scripts/bootstrap.bundle.js"></script>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Information Page</title>
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
<form id="form1" runat="server">
    <div class="container">

        <h1 style="color: rgba(254, 252, 251, 0.7)" class="m-5 d-flex justify-content-center">Information</h1>
        <div class="d-flex mt-5 justify-content-center">
            <asp:table class="table table-user-information" CellPadding="10" CssClass="courses table-striped" ID="information" runat="server">

                <asp:TableRow runat="server" ID="IDRow">
                    <asp:TableCell>
                        <strong>ID</strong>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server" ID="firstNameRow">
                    <asp:TableCell>
                        <strong>First Name</strong>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server" ID="lastNameRow">
                    <asp:TableCell>
                        <strong>Last Name</strong>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server" ID="passwordRow">
                    <asp:TableCell>
                        <strong>Password</strong>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server" ID="emailRow">
                    <asp:TableCell>
                        <strong>Email</strong>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server" ID="genderRow">
                    <asp:TableCell>
                        <strong>Gender</strong>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server" ID="addressRow">
                    <asp:TableCell>
                        <strong>Address</strong>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server" ID="gpaRow">
                    <asp:TableCell>
                        <strong>GPA</strong>
                    </asp:TableCell>
                </asp:TableRow>

            </asp:table>
        </div>
    </div>
</form>
</body>
</html>