<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="UsingCookies.WebForm1" %>

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

            <asp:Label ID="lblWelcome" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" CssClass="auto-style1" Height="50px" Text="Label" Width="259px"></asp:Label>
            <br />
            <br />
            Name:
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:Button ID="btnCookie" runat="server" OnClick="btnCookie_Click" Text="Create Cookie" />
        </div>
    </form>
</body>
</html>