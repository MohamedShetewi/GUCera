<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddNewCourse.aspx.cs" Inherits="GUCera.AddNewCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add New Course</title>
    <link href="Content/bootstrap.css" rel="stylesheet"/>
    <script src="Scripts/bootstrap.bundle.js"></script>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <style>
             body{
                            background-color: #29BE75;
                        }
                        .details{
                            background-color: rgba(254, 252, 251, 0.8);
                            border-radius: 20px;
                            width: 35%;
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
                    <a class="nav-link" href="InstructorHomePage.aspx">
                        Instructor Dashboard
                    </a>
                </li>
            </ul>
        </div>
    </div>
</nav>
<h1 style="color: white" class="m-5 d-flex justify-content-center">Enter Course Details</h1>
<form id="form1" runat="server">
    <div class="d-flex justify-content-center">
        <div class="container details p-4">
            <div class="row mb-3">
                <div class="col">
                    Name
                </div>
                <div class="col">
                    <asp:TextBox ID="courseName" runat="server" CssClass="form-control" TextMode="Number" required></asp:TextBox>
                </div>
            </div>
            <div class="row mb-3">
                <div class="col"> Credit hours</div>
                <div class="col">
                    <asp:TextBox ID="creditHours" runat="server" CssClass="form-control" required></asp:TextBox>
                </div>
            </div>
            <div class="row mb-3">
                <div class="col">
                    Price
                </div>
                <div class="col">
                    <asp:TextBox ID="price" runat="server" CssClass="form-control" required></asp:TextBox>
                </div>
            </div>
            <div class="row justify-content-center">
                <asp:Button ID="addButton" runat="server" Text="Add" OnClick="addButton_Click" CssClass="btn btn-primary" style="max-width: fit-content;"/>
            </div>
        </div>
    </div>
    <div class="d-flex justify-content-center mt-4" runat="server" id="message">
        <div class="alert alert-success" role="alert">
            Course Created Successfully!
        </div>
    </div>
    <div class="d-flex justify-content-center mt-4" runat="server" id="errorMessage">
        <div class="alert alert-danger" role="alert">
            Invalid Inputs!
        </div>
    </div>
</form>
</body>
</html>