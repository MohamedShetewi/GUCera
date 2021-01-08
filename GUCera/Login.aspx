<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GUCera.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="id" runat="server" required></asp:TextBox>
        </div>
        Password<asp:TextBox ID="password" runat="server" TextMode="Password" required></asp:TextBox>
        <p>
            <asp:Button ID="login_button" runat="server" OnClick="Button1_Click" Text="Login" />
        </p>
    </form>
</body>
</html>
