<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentHomePage.aspx.cs" Inherits="GUCera.StudentHomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-giJF6kkoqNQ00vy+HMDP7azOuL0xtbfIcaT9wjKHr8RbDVddVHyTfAAsrekwKmP1" crossorigin="anonymous">
</head>
<meta charset="utf-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
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
    <div>
    </div>


    ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
    <asp:Label ID="idLabel" runat="server"></asp:Label>

    <br/>

    First Name&nbsp;&nbsp;
    <asp:Label ID="firstNameLabel" runat="server"></asp:Label>

    <br/>

    Last Name&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lastNameLabel" runat="server"></asp:Label>

    <br/>

    Password&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="passwordLabel" runat="server"></asp:Label>

    <br/>

    Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="emailLabel" runat="server"></asp:Label>

    <br/>
    Gender&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="genderLabel" runat="server"></asp:Label>

    <br/>
    Address&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="addressLabel" runat="server"></asp:Label>

    <br/>
    GPA&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="gpaLabel" runat="server"></asp:Label>
    <br/>
    <asp:Button ID="listCourseBtn" onClick="availableCourses_OnClick" runat="server" Text="List Courses"/>
    <br/>
    <asp:Button ID="addCreditCard" onClick="addCreditCard_OnClick" runat="server" Text="Add Credit Card"/>
    <br/>
    <asp:Button ID="viewPromoCodes" onClick="viewPromoCodes_OnClick" runat="server" Text="Promocodes"/>
</form>
</body>
</html>