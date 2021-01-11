<%@ Page Language="C#" CodeBehind="AddCreditCard.aspx.cs" Inherits="GUCera.AddCreditCard" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Credit Card</title>
</head>
<body>
<form id="HtmlForm" runat="server">
    <div>
        <asp:Label runat="server"  Text="Credit Card Number" ></asp:Label>
        <asp:TextBox runat="server" ID="creditCardNumber" required></asp:TextBox>
        <br/>
        <asp:Label runat="server" Text="Credit Card Holder Name"></asp:Label>
        <asp:TextBox runat="server" ID="holderName" required></asp:TextBox>
        <br/>

        <asp:Label runat="server" Text="Expiry Date" ></asp:Label>
        <asp:TextBox runat="server" TextMode="DateTime" ID="expiryDate" required></asp:TextBox>
        <br/>

        <asp:Label runat="server" Text="CVV"></asp:Label>
        <asp:TextBox runat="server" ID="cvv" required></asp:TextBox>
        <br/>
        <asp:Button runat="server" Text="Add" ID="addCreditCard" OnClick="add_OnClick"/>
        


    </div>
</form>
</body>
</html>