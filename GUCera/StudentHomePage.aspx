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
                  .courses{
                    border-radius: 20px;      
                    background-color: rgba(254, 252, 251, 0.7);
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
                            <a class="dropdown-item" href="StudentInformationPage.aspx">Student Information</a>
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
    <div class="container-fluid">
        <div class="row">
            <div class="container col-4 mt-5 pb-5 text-center" style="background-color: rgba(254, 252, 251, 0.8); border-radius: 20px">
                <h3 class="mt-2" style="text-align: center">Available Courses</h3><br/>
                <asp:Button runat="server" ID="btn1" CssClass="btn btn-primary" Text="View" OnClick="availableCourses_OnClick"/>
            </div>
            <div class="container col-4 mt-5 pb-5 text-center" style="background-color: rgba(254, 252, 251, 0.8); border-radius: 20px">
                <h3 class="mt-2" style="text-align: center">Add Credit Card</h3><br/>
                <asp:Button runat="server" ID="btn2" CssClass="btn btn-primary" Text="Add" OnClick="addCreditCard_OnClick"/>
            </div>
        </div>
        <div class="row">
            <div class="container col-4 mt-5 pb-5 text-center" style="background-color: rgba(254, 252, 251, 0.8); border-radius: 20px">
                <h3 class="mt-2">View Promocodes</h3><br/>
                <asp:Button runat="server" ID="btn3" CssClass="btn btn-primary" Text="View" OnClick="viewPromoCodes_OnClick"/>
            </div>
            
        </div>
       
    </div>
</form>
</body>
</html>