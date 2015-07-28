<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Web_Controls.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstNumber" runat="server" Height="190px" SelectionMode="Multiple">
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
            <asp:TextBox ID="txtNumberDisplay" runat="server" TextMode="MultiLine" Height="146px" Width="337px"></asp:TextBox>
            <asp:Button ID="btnWrite" runat="server" OnClick="btnWrite_Click" />


            <h1>Go To next page </h1>
            <a href="WebForm2.aspx">Prac 2</a>
        </div>
    </form>
</body>
</html>
