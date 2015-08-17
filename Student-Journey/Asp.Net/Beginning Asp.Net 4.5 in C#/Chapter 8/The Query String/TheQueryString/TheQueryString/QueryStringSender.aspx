<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryStringSender.aspx.cs" Inherits="TheQueryString.Index" Trace="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
        }
    </style>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:ListBox ID="lstItems" runat="server" CssClass="auto-style1" Height="100px" OnSelectedIndexChanged="lstItems_SelectedIndexChanged" SelectionMode="Multiple" Width="198px"></asp:ListBox>
            <br />
            <br />
            <asp:CheckBox Checked="true" ID="chkDetails" Text="Show Full Details" runat="server" />
            <br />
            <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button runat="server" ID="btnViewInformation" Text="View Information" OnClick="btnViewInformation_Click" />
        </div>
    </form>
</body>
</html>