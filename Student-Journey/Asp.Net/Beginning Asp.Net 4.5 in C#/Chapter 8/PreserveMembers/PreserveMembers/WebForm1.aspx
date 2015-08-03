<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PreserveMembers.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtValue" runat="server" Text="This is a test of the Perserve Members.aspx page" Height="110px" TextMode="MultiLine" Width="422px"></asp:TextBox>
        <br />
        <asp:Button ID="btnSave" runat="server" Text="Save Contents" OnClick="btnSave_Click" />
        &nbsp;
        <asp:Button ID="btnLoad" runat="server" Text="Load Contents" OnClick="btnLoad_Click" />
    </div>
    </form>
</body>
</html>
