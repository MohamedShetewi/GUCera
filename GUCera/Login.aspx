<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GUCera.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
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
                          min-height:50%;  /* Fallback for browsers do NOT support vh unit */
                          min-height: 60vh; /* These two lines are counted as one :-)       */
                        
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
<form id="form1" runat="server">
    <div class="vertical-center">
        <div class="container inputs p-4">
            <div class="row mb-2">
                <div class="col">ID </div>
                <div class="col-6">
                    <asp:TextBox ID="id" runat="server" CssClass="form-control" TextMode="Number" required></asp:TextBox>
                </div>
            </div>
            <div class="row mb-3">
                <div class="col"> Password</div>
                <div class="col-6">
                    <asp:TextBox ID="password" runat="server" TextMode="Password" CssClass="form-control" required></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="col">
                    <asp:Button ID="login_button" runat="server" CssClass="btn btn-primary" OnClick="Button1_Click" Text="Login"/>
                </div>
                <div class="col">
                    <a href="Registeration.aspx">I don't have an account</a>
                </div>
            </div>
        </div>
    </div>
    <div class="d-flex justify-content-center" runat="server" ID="errorMessage">
        <div class="alert alert-danger" role="alert" style="max-width: fit-content">
            Invalid Credentials!
        </div>
    </div>
</form>
</body>
</html>