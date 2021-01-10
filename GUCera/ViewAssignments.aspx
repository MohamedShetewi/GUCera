<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAssignments.aspx.cs" Inherits="GUCera.ViewAssignments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Course ID<asp:TextBox ID="courseID" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="viewButton" runat="server" Text="View Assignments" OnClick="viewButton_Click" />
            <br />
            <asp:Table ID="table" runat="server" Width="100%"> 
    <asp:TableRow>
        <asp:TableCell>Student ID</asp:TableCell>
        <asp:TableCell>Course ID</asp:TableCell>
        <asp:TableCell>Assignment number</asp:TableCell>
        <asp:TableCell>Assignment type</asp:TableCell>
        <asp:TableCell>Grade</asp:TableCell>
    </asp:TableRow>
</asp:Table>  
        </div>
    </form>
</body>
</html>
