<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentHomePage.aspx.cs" Inherits="GUCera.StudentHomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" xmlns="http://www.w3.org/1999/html">
<head runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet"/>
    <script src="Scripts/bootstrap.bundle.js"></script>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Student Home Page</title>
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
                   .inputs{
                                      background-color: rgba(254, 252, 251, 0.8);
                                      border-radius: 20px;
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
            </ul>
        </div>
    </div>
</nav>
<form id="form1" runat="server">
    <div class="container bootstrap snippets bootdey">


        <div class="d-flex mt-5 justify-content-center">

      


            <asp:table class="table table-user-information" ID="information" runat="server">

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

    <br/>
    <asp:Button ID="listCourseBtn" onClick="availableCourses_OnClick" runat="server" Text="List Courses"/>
    <br/>
    <asp:Button ID="addCreditCard" onClick="addCreditCard_OnClick" runat="server" Text="Add Credit Card"/>
    <br/>
    <asp:Button ID="viewPromoCodes" onClick="viewPromoCodes_OnClick" runat="server" Text="Promocodes"/>
</form>

</body>
</html>