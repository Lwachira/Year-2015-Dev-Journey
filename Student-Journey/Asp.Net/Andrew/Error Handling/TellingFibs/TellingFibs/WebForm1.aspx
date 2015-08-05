<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TellingFibs.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtresult" runat="server" TextMode="MultiLine" Height="235px"></asp:TextBox>
        From<asp:TextBox ID="txtStrtNum" runat="server" Width="67px"></asp:TextBox>
&nbsp; To
        <asp:TextBox ID="txtEndNum" runat="server" Width="67px"></asp:TextBox>
&nbsp;<asp:Button ID="btnFib" runat="server" OnClick="btnFib_Click" Text="Just Do It" />
    </div>
    </form>
</body>
</html>
