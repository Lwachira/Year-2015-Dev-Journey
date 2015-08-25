<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Practical_2.WebForm2" %>

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

            <asp:Label ID="lblGreeting" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="lblDisplay" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
            <asp:ListBox ID="lstBoxDisplay" runat="server" BackColor="#669999" CssClass="auto-style1" ForeColor="Black" Height="240px" Width="371px"></asp:ListBox>
        </div>
    </form>
</body>
</html>