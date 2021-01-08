<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddMobileNumber.aspx.cs" Inherits="GUCera.addMobileNumber" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Mobile Number&nbsp;
            <asp:TextBox ID="mobilenumber" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="addButton" runat="server" Text="Add" OnClick="Button1_Click" style="height: 26px" />
    </form>
</body>
</html>
