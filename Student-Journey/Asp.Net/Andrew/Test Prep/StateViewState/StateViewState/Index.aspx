<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="StateViewState.Index" %>

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

            <asp:Label Text="text" runat="server" Width="199px" CssClass="auto-style1" Height="30px" BorderWidth="1" ID="lblMessage" />
            <br />
            <br />
            <asp:Button Text="Increase" ID="btnIncrease" runat="server" OnClick="btnIncrease_Click" />

            <asp:Button Text="Decrease" ID="btnDecrease" runat="server" OnClick="btnDecrease_Click" />
        </div>
    </form>
</body>
</html>