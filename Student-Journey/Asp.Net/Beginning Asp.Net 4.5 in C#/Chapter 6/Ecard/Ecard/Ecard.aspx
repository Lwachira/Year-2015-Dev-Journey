<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ecard.aspx.cs" Inherits="Ecard.Ecard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Choose a background color:
        <br />
            <br />
            <asp:DropDownList ID="lstBackColor" AutoPostBack="true" OnSelectedIndexChanged="controlChanged" runat="server" Width="194px" Height="22px" />
            <br />
            Choose a foreground (text) color:<br />
            <asp:DropDownList ID="lstForeColor" runat="server" Height="22px" Width="194px" AutoPostBack="True" OnSelectedIndexChanged="controlChanged"></asp:DropDownList><br />
            <br />
            Choose a font name:<br />
            <br />
            <asp:DropDownList ID="lstFontName" AutoPostBack="true" OnSelectedIndexChanged="controlChanged" runat="server" Width="194px" Height="22px" />
            <br />
            Specify a number font size:<br />
            <br />
            <asp:TextBox ID="txtFontSize" AutoPostBack="true" OnTextChanged="controlChanged" runat="server" /><br />
            Choose a border style<br />
            <br />
            <asp:RadioButtonList ID="lstBorder" AutoPostBack="true" OnSelectedIndexChanged="controlChanged" RepeatColumns="2" runat="server" Width="177px" Height="59px" />
            <br />
            <asp:CheckBox ID="chkPicture" AutoPostBack="true" OnCheckedChanged="controlChanged" runat="server" Text="Add the default picture" />
            <br />
            Enter the greeting text below:<br />
            <asp:TextBox ID="txtGreeting" AutoPostBack="true" runat="server" Width="240px" Height="85px" TextMode="MultiLine" OnTextChanged="controlChanged">
            </asp:TextBox>
            <br />
            <br />
            <asp:Button runat="server" ID="cmdUpdate" OnClick="cmdUpdate_Click" Width="71px" Height="24px" Text="Update" />
        </div>

        <asp:Panel ID="pnlCard" runat="server" Width="339" HorizontalAlign="Center" Style="position: absolute; top: 16px; left: 313px; height: 433px;">
            <br />
            &nbsp;
            <asp:Label ID="lblGreeting" runat="server" Width="256px" Height="150px">

            </asp:Label>
            <br />
            <br />
            <br />
            <asp:Image ID="imgDefault" runat="server" Width="212px" Height="160px" />

        </asp:Panel>
    </form>
</body>
</html>
