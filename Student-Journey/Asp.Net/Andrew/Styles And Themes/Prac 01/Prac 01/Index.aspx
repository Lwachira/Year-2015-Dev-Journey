<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Prac_01.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        h1 {
            text-align: center;
        }

        #divName {
            text-align: center;
        }

        .auto-style1 {
        }

        .auto-style2 {
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Heading</h1>

            <span>First Name:
                <asp:TextBox runat="server" ID="txtFirstName" /></span>
            &nbsp
            &nbsp
            &nbsp
            <span>Last Name:
                <asp:TextBox runat="server" ID="txtLastName" />
                <br />
            </span>
            <div id="divName">

                <asp:Label Text="First Name And last Name" runat="server" Width="376px" ID="lblText" Font-Size="X-Large" CssClass="auto-style2" />
                <br />
                <br />
                <asp:Button Text="Write" runat="server" Width="164px" CssClass="auto-style1" ID="btnWrite" OnClick="btnWrite_Click" />
            </div>
            <h2>Theme Controls</h2>

            <asp:RadioButtonList runat="server" ID="rdoTheme" AutoPostBack="True" OnSelectedIndexChanged="rdoTheme_SelectedIndexChanged">
                <asp:ListItem Text="Theme 1" Value="themeDark" />
                <asp:ListItem Text="Theme 2" Value="themeBlue" />
            </asp:RadioButtonList>
        </div>
    </form>
</body>
</html>