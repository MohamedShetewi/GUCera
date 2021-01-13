<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Certificates.aspx.cs" Inherits="GUCera.Certificates" %>

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
            <asp:Button ID="Button1" runat="server" Text="View Certificate" CssClass="btn btn-primary" style="max-width: fit-content;" OnClick="viewButton_Click"/>
            <br />
        </div>
         <h1 style="color: black" class="d-flex justify-content-center mt-4" runat="server" ID="tableTitle">Certificate</h1>
        <div class="d-flex justify-content-center text-center mt-3">
        <asp:Table ID="table" runat="server" CssClass="table table-bordered table-striped table-hover assignments">
        </asp:Table>
    </div>
        <div class="d-flex justify-content-center mt-4" runat="server" ID="errorMessage">
        <div class="alert alert-danger" role="alert" style="max-width: fit-content">
            Invalid Inputs!
        </div>
    </div>
    </form>
</body>
</html>
