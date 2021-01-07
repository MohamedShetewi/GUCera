<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registeration.aspx.cs" Inherits="GUCera.Registeration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            First name&nbsp;&nbsp; &nbsp;<asp:TextBox ID="firstName" runat="server" Width="221px"></asp:TextBox>
            <br />
             Last name&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="lastName" runat="server" Width="220px"></asp:TextBox>
            <br />
             Password&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="password" runat="server" Width="219px"></asp:TextBox>
            <br />
             Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="email" runat="server" Width="223px"></asp:TextBox>
            <br />
            Address&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="address" runat="server" Width="225px"></asp:TextBox>
            <br />
            Gender&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:DropDownList ID="gender" runat="server" Width="230px">
                <asp:ListItem Value="0">Female</asp:ListItem>
                <asp:ListItem Value="1">Male</asp:ListItem>
            </asp:DropDownList>
            <br />
            I am a/an&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="type" runat="server" Width="231px">
                <asp:ListItem Value="2">Student</asp:ListItem>
                <asp:ListItem Value="0">Instructor</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="register" runat="server" Text="Register" oncLick="register_Click"/>
            <br />
            <br />
            <br />

        </div> 
    </form>
</body>
</html>
