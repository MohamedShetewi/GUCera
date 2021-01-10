<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GradeAssignments.aspx.cs" Inherits="GUCera.GradeAssignments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Student ID<asp:TextBox ID="studentID" runat="server"></asp:TextBox>
            <br />
            Course ID<asp:TextBox ID="courseID" runat="server"></asp:TextBox>
            <br />
            Assignment number<asp:TextBox ID="assignmentNumber" runat="server"></asp:TextBox>
            <br />
            Assignment type<asp:DropDownList ID="assignmentType" runat="server">
                <asp:ListItem>Exam</asp:ListItem>
                <asp:ListItem>Project</asp:ListItem>
                <asp:ListItem>Quiz</asp:ListItem>
            </asp:DropDownList>
            <br />
            Grade<asp:TextBox ID="grade" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="updateButton" runat="server" Text="Update grade" OnClick="updateButton_Click" />
            <br />
        </div>
    </form>
</body>
</html>
