<%@ Page Language="C#" CodeBehind="CreatePromocode.aspx.cs" Inherits="GUCera.CreatePromocode" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create Promocode</title>
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
        <h1 style="color: white" class="m-5 d-flex justify-content-center">Enter Promocode Details</h1>
        <div class="d-flex justify-content-center">
            <div class="container details p-4">
                <div class="row mb-3">
                    <div class="col">
                        Code:
                    </div>
                    <div class="col">
                        <asp:TextBox runat="server" ID="code" CssClass="form-control" placeholder="eg. FG1345" required></asp:TextBox>
                    </div>
                </div>
                <div class="row mb-3">
                    <div class="col">
                        Expiry Date:
                    </div>
                    <div class="col">
                        <asp:TextBox runat="server" ID="expiryDate" CssClass="form-control" TextMode="Date" placeholder="dd-mm-yyyy" required></asp:TextBox>
                    </div>
                </div>
                <div class="row mb-3">
                    <div class="col">
                        Discount:
                    </div>
                    <div class="col">
                        <asp:TextBox runat="server" ID="discount" CssClass="form-control" TextMode="Number" placeholder="eg. 35" required></asp:TextBox>
                    </div>
                </div>
                <div class="row justify-content-center mt-4">
                    <asp:Button runat="server" Text="Create" ID="createBtn" CssClass="btn btn-primary" OnClick="createBtn_OnClick" style="max-width: fit-content;"/>
                </div>
            </div>
        </div>
        <div class="d-flex justify-content-center mt-4" runat="server" id="message">
            <div class="alert alert-success" role="alert">
                Promocode Created Successfully!
            </div>
        </div>
        <div class="d-flex justify-content-center mt-4" runat="server" id="errorMessage">
            <div class="alert alert-danger" role="alert">
                Invalid Input!
            </div>
        </div>
    </div>
</form>
</body>
</html>