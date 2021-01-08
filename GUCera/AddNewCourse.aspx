<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddNewCourse.aspx.cs" Inherits="GUCera.AddNewCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name<asp:TextBox ID="courseName" runat="server" OnTextChanged="courseName_TextChanged"></asp:TextBox>
            <br />
            Credit hours<asp:TextBox ID="creditHours" runat="server"></asp:TextBox>
            <br />
            Price<asp:TextBox ID="price" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="addButton" runat="server" Text="Add" OnClick="addButton_Click" />
        </div>
    </form>
</body>
</html>
