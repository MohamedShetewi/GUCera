<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IssueCertificate.aspx.cs" Inherits="GUCera.IssueCertificate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Isseue Certificate</title>
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
<h1 style="color: white" class="m-5 d-flex justify-content-center">Enter Certificate Details</h1>
<form id="form1" runat="server">
    <div class="d-flex justify-content-center">
        <div class="container details p-4">
            <div class="row mb-2">
                <div class="col">
                    Course ID
                </div>
                <div class="col">
                    <asp:TextBox ID="courseID" runat="server" TextMode="Number" CssClass="form-control" required></asp:TextBox>
                </div>
            </div>
            <div class="row mb-2">
                <div class="col">
                    Student ID
                </div>
                <div class="col">
                    <asp:TextBox ID="studentID" runat="server" TextMode="Number" CssClass="form-control" required></asp:TextBox>
                </div>
            </div>
            <div class="row mb-2">
                <div class="col">
                    Issue date
                </div>
                <div class="col">
                    <asp:TextBox ID="issueDate" TextMode="Date" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="row justify-content-center">
                <asp:Button ID="issueButton" runat="server" Text="Issue" CssClass="btn btn-primary" OnClick="issueButton_Click" style="max-width: fit-content;"/>
            </div>
        </div>
    </div>
    <div class="d-flex justify-content-center mt-4" runat="server" id="message">
        <div class="alert alert-success" role="alert">
            Assignment Defined Successfully!
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