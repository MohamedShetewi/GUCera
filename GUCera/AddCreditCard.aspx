<%@ Page Language="C#" CodeBehind="AddCreditCard.aspx.cs" Inherits="GUCera.AddCreditCard" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Credit Card</title>
    <link href="Content/bootstrap.css" rel="stylesheet"/>
    <script src="Scripts/bootstrap.bundle.js"></script>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <style>
        body{
            height: 100%;
            background-color: rgb(41,190,117);
        }
        .container{
            max-width: fit-content;
        }
        .vertical-center {
                  min-height:70%;  /* Fallback for browsers do NOT support vh unit */
                  min-height: 70vh; /* These two lines are counted as one :-)       */
                
                  display: flex;
                  align-items: center;        
        }
        h1{
            text-align: center;
            margin-top: 5%;
            color: white;
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


<form id="HtmlForm" runat="server">
    <div class="vertical-center">
        <div class="container inputs p-5">
            <div class="row mb-2">
                <div class="col">Credit Card Number</div>
                <div class="col-8">
                    <asp:TextBox ID="creditCardNumber" runat="server" class="form-control" required placeholder="eg. 515168315"></asp:TextBox>
                </div>
            </div>
            <div class="row mb-2">
                <div class="col">Credit Card Holder Name</div>
                <div class="col-8">
                    <asp:TextBox ID="holderName" runat="server" class="form-control" required placeholder="eg. Ahmad"></asp:TextBox>
                </div>
            </div>
            <div class="row mb-2">
                <div class="col">
                    Expiry Date
                </div>
                <div class="col-8">
                    <asp:TextBox ID="expiryDate" runat="server" class="form-control" TextMode="Date" required placeholder="Choose Date"></asp:TextBox>
                </div>
            </div>
            <div class="row mb-2">
                <div class="col">CVV</div>
                <div class="col-8">
                    <asp:TextBox ID="cvv" runat="server" class="form-control" required placeholder="eg. 125"></asp:TextBox>
                </div>
            </div>
            <div class="text-center mb-2 mt-3">
                <asp:Button runat="server" Text="Add" oncLick="add_OnClick" class="btn btn-primary"/>
            </div>
            <div class="d-flex justify-content-center" runat="server" ID="successMessage">
                <div class="alert alert-success" role="alert" style="max-width: fit-content">
                    Added Successfully!
                </div>
            </div>
            <div class="d-flex justify-content-center" runat="server" ID="errorMessage">
                <div class="alert alert-danger" role="alert" style="max-width: fit-content">
                    Already Added!
                </div>
            </div>
        </div>
    </div>
</form>
</body>
</html>