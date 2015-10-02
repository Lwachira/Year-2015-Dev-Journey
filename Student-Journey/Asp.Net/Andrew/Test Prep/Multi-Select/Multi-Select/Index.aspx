<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Multi_Select.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
        }

        .auto-style2 {
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox runat="server" CssClass="auto-style1" Height="205px" Width="85px" ID="lstNumbers" SelectionMode="Multiple">
                <asp:ListItem Text="One" />
                <asp:ListItem Text="Two" />
                <asp:ListItem Text="Three" />
                <asp:ListItem Text="Four" />
                <asp:ListItem Text="Five" />
                <asp:ListItem Text="Six" />
                <asp:ListItem Text="Seven" />
                <asp:ListItem Text="Eight" />
                <asp:ListItem Text="Nine" />
                <asp:ListItem Text="Ten" />
                <asp:ListItem Text="Eleven" />
            </asp:ListBox>
            <asp:TextBox ID="txtValues" runat="server" TextMode="MultiLine" CssClass="auto-style2" Height="173px" Width="226px"></asp:TextBox>
            <asp:Button Text="Do" runat="server" ID="btnDo" OnClick="btnDo_Click" />
        </div>
    </form>
</body>
</html>