<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddFeedback.aspx.cs" Inherits="GUCera.AddFeedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Course ID"></asp:Label>
            <asp:TextBox ID="courseID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Comment"></asp:Label>
            <asp:TextBox ID="comment" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Add Feedback" CssClass="btn btn-primary" style="max-width: fit-content;" OnClick="viewButton_Click"/>
            <br />
        </div>
         <div class="d-flex justify-content-center mt-4" runat="server" ID="message">
            <div class="alert alert-success" role="alert" style="max-width: fit-content">
                Feedback Added Successfully!
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
