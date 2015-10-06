<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="QueryString.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            First Name<asp:TextBox runat="server" ID="txtFirstName" />
            <br />
            Last Name<asp:TextBox runat="server" ID="txtLastName" />
            <br />
            <asp:Button Text="Query" runat="server" ID="btnQuery" OnClick="btnQuery_Click" />
        </div>
    </form>
</body>
</html>