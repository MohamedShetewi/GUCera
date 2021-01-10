<%@ Page Language="C#" CodeBehind="AcceptCourse.aspx.cs" Inherits="GUCera.AcceptCourse" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Accept a Course</title>
    <link href="Content/bootstrap.css" rel="stylesheet"/>
    <script src="Scripts/bootstrap.bundle.js"></script>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <style type="text/css">
            body{
                background-color: #29BE75;
                width: 100%;
            }
            .data{
                background-color: rgba(254, 252, 251, 0.8);
                border-radius: 20px;
                width: 40%;
            }
            .acceptBtn{
                max-width: fit-content;
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
                    <a class="nav-link" href="AdminHomePage.aspx">
                        Admin Dashboard
                    </a>
                </li>
            </ul>
        </div>
    </div>
</nav>
<form id="HtmlForm" runat="server">
    <div>
        <div class="container data mt-5 text-center p-4 mb-5">
            <h3 class="mb-3">Enter Course Info:</h3><br/>
            <div class="row mb-4">
                <div class="col">
                    <h4>ID:</h4>
                </div>
                <div class="col">
                    <asp:TextBox runat="server" ID="courseId" CssClass="form-control" placeholder="eg. 3" TextMode="Number" required></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="col">
                    <asp:Button runat="server" ID="acceptBtn" CssClass="btn btn-success acceptBtn" OnClick="acceptBtn_OnClick" Text="Accept Course"/>
                </div>
            </div>
        </div>
        <div class="d-flex justify-content-center" runat="server" ID="message">
            <div class="alert alert-success" role="alert" style="max-width: fit-content">
                Course Accepted Successfully!
            </div>
        </div>
        <div class="d-flex justify-content-center" runat="server" ID="errorMessage">
            <div class="alert alert-danger" role="alert" style="max-width: fit-content">
                Invalid Input!
            </div>
        </div>
    </div>
</form>
</body>
</html>