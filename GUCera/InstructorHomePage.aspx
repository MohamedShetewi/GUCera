<%@ Page Language="C#" CodeBehind="InstructorHomePage.aspx.cs" Inherits="GUCera.InstructorHomePage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link href="Content/bootstrap.css" rel="stylesheet"/>
    <script src="Scripts/bootstrap.bundle.js"></script>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <style type="text/css">
            body{
                background-color: #29BE75;
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
<form id="HtmlForm" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="container col-4 mt-5 pb-5 text-center" style="background-color: rgba(254, 252, 251, 0.8); border-radius: 20px">
                <h3 class="mt-2" style="text-align: center">Add a New Course</h3><br/>
                <asp:Button runat="server" ID="btn1" CssClass="btn btn-primary" Text="Add" OnClick="btn1_OnClick"/>
            </div>
            <div class="container col-4 mt-5 pb-5 text-center" style="background-color: rgba(254, 252, 251, 0.8); border-radius: 20px">
                <h3 class="mt-2" style="text-align: center">Define Assignments For a Specific Course</h3><br/>
                <asp:Button runat="server" ID="btn2" CssClass="btn btn-primary" Text="Define" OnClick="btn2_OnClick"/>
            </div>
        </div>
        <div class="row">
            <div class="container col-4 mt-5 pb-5 text-center" style="background-color: rgba(254, 252, 251, 0.8); border-radius: 20px">
                <h3 class="mt-2">View Assignments</h3><br/>
                <asp:Button runat="server" ID="btn3" CssClass="btn btn-primary" Text="View" OnClick="btn3_OnClick"/>
            </div>
            <div class="container col-4 text-center mt-5 pb-5" style="background-color: rgba(254, 252, 251, 0.8); border-radius: 20px">
                <h3 class="mt-2">Grade Assignments</h3>
                <asp:Button runat="server" ID="btn4" CssClass="btn btn-primary" Text="Grade" OnClick="btn4_OnClick"/>
            </div>

        </div>
        <div class="row">
            <div class="container col-4 mt-5 pb-5 text-center" style="background-color: rgba(254, 252, 251, 0.8); border-radius: 20px">
                <h3 class="mt-2">View Feedbacks On My Course</h3><br/>
                <asp:Button runat="server" ID="btn5" CssClass="btn btn-primary" Text="View" OnClick="btn5_OnClick"/>
            </div>
            <div class="col-4 container mt-5 pb-5 text-center" style="background-color: rgba(254, 252, 251, 0.8); border-radius: 20px">
                <h3 class="mt-2">Issue a Certificate To a Student</h3><br/>
                <asp:Button runat="server" ID="btn6" CssClass="btn btn-primary" Text="Issue" OnClick="btn6_OnClick"/>
            </div>
        </div>
    </div>
</form>
</body>
</html>