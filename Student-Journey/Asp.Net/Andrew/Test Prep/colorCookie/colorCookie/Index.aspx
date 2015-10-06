<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="colorCookie.Index" %>

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
            <asp:ListBox runat="server" AutoPostBack="True" CssClass="auto-style1" Height="154px" Width="149px" ID="lstColor" OnSelectedIndexChanged="lstColor_SelectedIndexChanged">
                <asp:ListItem Text="Red" />
                <asp:ListItem Text="Blue" />
                <asp:ListItem Text="Orange" />
                <asp:ListItem Text="Pink" />
            </asp:ListBox>
            <br />
            <asp:Label Text="text" runat="server" ID="lblMessage" />
        </div>
    </form>
</body>
</html>