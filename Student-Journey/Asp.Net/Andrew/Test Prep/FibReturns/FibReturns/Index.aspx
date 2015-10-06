<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="FibReturns.Index" %>

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
            <asp:ListBox runat="server" CssClass="auto-style1" Height="147px" Width="130px" ID="lstFib"></asp:ListBox>
            From
            <asp:TextBox runat="server" ID="txtFrom" />To
            <asp:TextBox runat="server" ID="txtTo" />
            <asp:Button Text="Do it" runat="server" ID="btnDoIT" OnClick="btnDoIT_Click" />
        </div>
    </form>
</body>
</html>