<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormSize.aspx.cs" Inherits="Prac_1___ViewState.WebFormSize" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <br />

            <asp:Label ID="lblMessage" runat="server" Height="47px" Width="227px" BorderStyle="Solid" BorderWidth="1" BorderColor="Black"></asp:Label>
            <br />
            <br />
            <br />

            <asp:Button ID="btnIncrease" runat="server" Text="Increase" OnClick="btnIncrease_Click" />
            &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDecrease" runat="server" Text="Decrease" OnClick="btnDecrease_Click" />
        </div>
    </form>
</body>
</html>