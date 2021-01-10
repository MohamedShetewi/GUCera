<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registeration.aspx.cs" Inherits="GUCera.Registeration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
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
<h1>GUCera</h1>
<form id="form1" runat="server" class="needs-validation">
    <div class="vertical-center">
        <div class="container inputs pt-5 ps-5 pb-5 pe-5">
            <div class="row mb-2">
                <div class="col">First Name</div>
                <div class="col-8">
                    <asp:TextBox ID="firstName" runat="server" class="form-control" required placeholder="eg. Mohammad"></asp:TextBox>
                </div>
            </div>
            <div class="row mb-2">
                <div class="col">Last name</div>
                <div class="col-8">
                    <asp:TextBox ID="lastName" runat="server" class="form-control" required placeholder="eg. Ahmad"></asp:TextBox>
                </div>
            </div>
            <div class="row mb-2">
                <div class="col">
                    Password
                </div>
                <div class="col-8">
                    <asp:TextBox ID="password" runat="server" class="form-control" TextMode="Password" required placeholder="Select a strong one"></asp:TextBox>
                </div>
            </div>
            <div class="row mb-2">
                <div class="col">Email</div>
                <div class="col-8">
                    <asp:TextBox ID="email" runat="server" class="form-control" TextMode="Email" required placeholder="exmaple@email.com"></asp:TextBox>
                </div>
            </div>
            <div class="row gy-10">
                <div class="col"> Address</div>
                <div class="col-8">
                    <asp:TextBox ID="address" runat="server" class="form-control" required placeholder="Enter a valid one"></asp:TextBox>
                </div>
            </div>
            <div class="row mb-2 mt-2">
                <div class="col"> Gender</div>
                <div class="col-8">
                    <asp:DropDownList ID="gender" runat="server" class="form-select">
                        <asp:ListItem Value="0">Female</asp:ListItem>
                        <asp:ListItem Value="1">Male</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="row mb-2">
                <div class="col"> I am a/an</div>
                <div class="col-8">
                    <asp:DropDownList ID="type" runat="server" class="form-select">
                        <asp:ListItem Value="2">Student</asp:ListItem>
                        <asp:ListItem Value="0">Instructor</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="text-center mb-2 mt-3">
                <asp:Button ID="register" runat="server" Text="Register" oncLick="register_Click" class="btn btn-outline-primary"/>
            </div>
        </div>
    </div>
</form>
</body>
</html>