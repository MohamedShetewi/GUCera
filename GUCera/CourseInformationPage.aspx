<%@ Page Language="C#" CodeBehind="Course.aspx.cs" Inherits="GUCera.Course" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Course Information</title>
</head>
<body>
<form id="HtmlForm" runat="server">
    <div>

        Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:Label ID="nameLabel" runat="server"></asp:Label>

        <br/>

        Credit Hours&nbsp;&nbsp;
        <asp:Label ID="creditHoursLabel" runat="server"></asp:Label>

        <br/>

        Price&nbsp;&nbsp;
        <asp:Label ID="priceLabel" runat="server"></asp:Label>

        <br/>

        Course Description&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="courseDesLabel" runat="server"></asp:Label>
        <br/>
        <asp:DropDownList ID="instructorList" runat="server" >
        </asp:DropDownList>
        <br/>
        <asp:Button runat="server" ID="enrollBtn" OnClick="enroll_OnClick" Text="Enroll"/>

    </div>
</form>
</body>
</html>