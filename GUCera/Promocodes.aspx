﻿<%@ Page Title="Title" Language="C#" CodeBehind="Promocodes.aspx.cs" Inherits="GUCera.Promocodes" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Title</title>
    <link href="Content/bootstrap.css" rel="stylesheet"/>
    <script src="Scripts/bootstrap.bundle.js"></script>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <style type="text/css">
                body{
                    background-color: #29BE75;
                }
                .courses{
                   width: 70%;
                    background-color: rgba(254, 252, 251, 0.7);
                    text-align: center;
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
                        <li>
                            <a class="dropdown-item" href="StudentInformationPage.aspx">Personal Information</a>
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
    <h1 style="color: white" class="m-5 d-flex justify-content-center">Promocodes</h1>
    <div class="container">
        <div class="d-flex mt-5 justify-content-center">
            <asp:Table style="width:100%" runat="server" ID="promocodes" CssClass="table table-bordered table-striped table-hover courses">
            </asp:Table>
        </div>
    </div>
</form>

</body>
</html>