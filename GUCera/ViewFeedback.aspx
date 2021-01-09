<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewFeedback.aspx.cs" Inherits="GUCera.ViewFeedback" %>

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
            <asp:Button ID="viewButton" runat="server" Text="View feedback" OnClick="viewButton_Click" />
            <br />
            <asp:Table ID="table" runat="server" Width="100%">
                <asp:TableRow>
        <asp:TableCell>Feedback ID</asp:TableCell>
        <asp:TableCell>Comment</asp:TableCell>
        <asp:TableCell>Likes</asp:TableCell>
       
    </asp:TableRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
