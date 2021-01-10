<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IssueCertificate.aspx.cs" Inherits="GUCera.IssueCertificate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            CourseID<asp:TextBox ID="courseID" runat="server"></asp:TextBox>
            <br />
            Student ID<asp:TextBox ID="studentID" runat="server"></asp:TextBox>
            <br />
            Issue date<asp:TextBox ID="issueDate" TextMode="Date" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="issueButton" runat="server" Text="Issue" OnClick="issueButton_Click" />
        </div>
    </form>
</body>
</html>
