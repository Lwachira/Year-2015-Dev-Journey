<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Web_Controls.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Button ID="btnDraw" Text="btnDraw" OnClick="btnDraw_Click" runat="server" />
            <br />
            <br />
            Rows<asp:TextBox ID="txtRow" runat="server"></asp:TextBox>
            Cols
            <asp:TextBox ID="txtCols" runat="server"></asp:TextBox>
            <br />
            <br />


            <asp:Table ID="tblOne" runat="server"></asp:Table>
            <asp:Label ID="lblError" runat="server" Visible="false" Text="Label"></asp:Label>

            <br />
            <br />
            <a href="WebForm3.aspx">Page 3</a>
        </div>
    </form>
</body>
</html>
