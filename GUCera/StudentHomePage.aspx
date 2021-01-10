<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentHomePage.aspx.cs" Inherits="GUCera.StudentHomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<form id="form1" runat="server">
    <div>
    </div>


    ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
    <asp:Label ID="idLabel" runat="server"></asp:Label>

    <br/>

    First Name&nbsp;&nbsp;
    <asp:Label ID="firstNameLabel" runat="server"></asp:Label>

    <br/>

    Last Name&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lastNameLabel" runat="server"></asp:Label>

    <br/>

    Password&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="passwordLabel" runat="server"></asp:Label>

    <br/>

    Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="emailLabel" runat="server"></asp:Label>

    <br/>
    Gender&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="genderLabel" runat="server"></asp:Label>

    <br/>
    Address&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="addressLabel" runat="server"></asp:Label>

    <br/>
    GPA&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="gpaLabel" runat="server"></asp:Label>
    <br/>
    <asp:Button ID="listCourseBtn" onClick="availableCourses_OnClick" runat="server" Text="List Courses"/>
    <br/>
    <asp:Button ID="addCreditCard" onClick="addCreditCard_OnClick" runat="server" Text="Add Credit Card"/>
    <br/>
    <asp:Button ID="viewPromoCodes" onClick="viewPromoCodes_OnClick" runat="server" Text="Promocodes"/>
</form>
</body>
</html>