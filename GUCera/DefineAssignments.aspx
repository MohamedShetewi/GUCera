<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DefineAssignments.aspx.cs" Inherits="GUCera.DefineAssignments" %>

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
            Assignment number<asp:TextBox ID="assignmentNumber" runat="server"></asp:TextBox>
            <br />
            Assignment type<asp:DropDownList ID="assignmentType" runat="server">
                <asp:ListItem>Exam</asp:ListItem>
                <asp:ListItem>Quiz</asp:ListItem>
                <asp:ListItem>Project</asp:ListItem>
            </asp:DropDownList>
            <br />
            Full grade<asp:TextBox ID="fullGrade" runat="server"></asp:TextBox>
            <br />
            Weight<asp:TextBox ID="weight" runat="server"></asp:TextBox>
            <br />
            Deadline<asp:TextBox ID="deadline" runat="server" TextMode="Date"/>
            <br />
            Content<asp:TextBox ID="content" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="define" runat="server" Text="Define assignment" OnClick="define_Click"/>
        </div>
    </form>
</body>
</html>
