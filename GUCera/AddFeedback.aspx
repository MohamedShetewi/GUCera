﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddFeedback.aspx.cs" Inherits="GUCera.AddFeedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Feedback</title>
    <link href="Content/bootstrap.css" rel="stylesheet"/>
    <script src="Scripts/bootstrap.bundle.js"></script>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <style type="text/css">
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
<form id="form1" runat="server">
    <h1 style="color: white" class="m-5 d-flex justify-content-center">Add Your Feedback</h1>
    <div class="d-flex justify-content-center">
        <div class="container details p-4">
            <div class="row mb-2">
                <div class="col">
                    Course ID
                </div>
                <div class="col">
                    <asp:TextBox ID="courseID" runat="server" CssClass="form-control" required></asp:TextBox>
                </div>
            </div>
            <div class="row mb-3">
                <div class="col">
                    Comment
                </div>
                <div class="col">
                    <asp:TextBox ID="comment" runat="server" CssClass="form-control" TextMode="MultiLine" required></asp:TextBox>
                </div>
            </div>
            <div class="row justify-content-center">
                <asp:Button ID="Button1" runat="server" Text="Add Feedback" CssClass="btn btn-primary" style="max-width: fit-content;" OnClick="viewButton_Click"/>
            </div>
        </div>
    </div>
    <div class="d-flex justify-content-center mt-4" runat="server" ID="message">
        <div class="alert alert-success" role="alert" style="max-width: fit-content">
            Feedback Added Successfully!
        </div>
    </div>
    <div class="d-flex justify-content-center mt-4" runat="server" ID="errorMessage">
        <div class="alert alert-danger" role="alert" style="max-width: fit-content">
            Invalid Inputs!
        </div>
    </div>
</form>
</body>
</html>