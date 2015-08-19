<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Session.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            First Name:
            <asp:TextBox ID="txtFName" runat="server"></asp:TextBox>
            &nbsp
        &nbsp
            Surname :
        <asp:TextBox ID="txtSName" runat="server"></asp:TextBox>

            <br />
            <br />
            <asp:Button ID="btnPage" runat="server" Text="Next Page" />
        </div>
    </form>
</body>
</html>