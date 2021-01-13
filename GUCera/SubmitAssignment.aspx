<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SubmitAssignment.aspx.cs" Inherits="GUCera.SubmitAssignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Course ID"></asp:Label>
            <asp:TextBox ID="courseID" runat="server"></asp:TextBox>
        </div>
            <asp:Label ID="Label3" runat="server" Text="Assignment number"></asp:Label>
            <asp:TextBox ID="assignmentnumber" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Assignment type"></asp:Label>
        <asp:DropDownList ID="assignmenttype" runat="server">
            <asp:ListItem>Quiz</asp:ListItem>
            <asp:ListItem>Project</asp:ListItem>
            <asp:ListItem>Exam</asp:ListItem>
        </asp:DropDownList>
        <br />
            <asp:Button ID="Button1" runat="server" Text="Submit Assignment" CssClass="btn btn-primary" style="max-width: fit-content;" OnClick="viewButton_Click"/>
            <div id="message" runat="server" class="d-flex justify-content-center mt-4">
                <div class="alert alert-success" role="alert" style="max-width: fit-content">
                   Assignment submitted successfully! </div>
            </div>
        </div>
        <div class="d-flex justify-content-center mt-4" runat="server" ID="errorMessage">
        <div class="alert alert-danger" role="alert" style="max-width: fit-content">
            Invalid Inputs!
        </div>
    </div>
    </form>
</body>
</html>
