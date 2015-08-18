<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormSize.aspx.cs" Inherits="Prac_1___ViewState.WebFormSize" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:Label ID="lblMessage" runat="server" BackColor="#000066" CssClass="auto-style1" ForeColor="White" Height="47px" Text="Label" Width="227px"></asp:Label>
        <br />
        <asp:Button ID="btnIncrease" runat="server" Text="Increase" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDecrease" runat="server" Text="Decrease" />
    </div>
    </form>
</body>
</html>