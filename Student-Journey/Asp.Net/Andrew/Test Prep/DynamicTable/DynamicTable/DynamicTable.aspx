<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DynamicTable.aspx.cs" Inherits="DynamicTable.DynamicTable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button Text="Draw" runat="server" ID="btnDraw" OnClick="btnDraw_Click" />
            <br />
            <br />
            Rows
            <asp:TextBox runat="server" ID="txtRows" />
            Cols
            <asp:TextBox runat="server" ID="txtCols" />

            <br />
            <asp:Table runat="server" ID="dTable" Visible="false">
            </asp:Table>
        </div>
    </form>
</body>
</html>